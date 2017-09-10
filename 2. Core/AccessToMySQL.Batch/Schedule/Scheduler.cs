using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessToMySQL.Infrastructure.Constantes;
using System.IO;
using AccessToMySQL.Infrastructure.Tools;
using AccessToMySQL.Core.Settings;
using Quartz;
using Quartz.Impl;

namespace AccessToMySQL.Batch.Schedule
{
    public class Scheduler
    {
        //AuthenticationServicesoapClient authClient;
        //string user = ConfigurationManager.AppSettings[Globals.USER];
        //string password = ConfigurationManager.AppSettings[Globals.PASSWORD];

        #region public methods
        /// <summary>
        /// Schedule : méthode sert à lire les fichier H' et lancer les parser et les parserBack suivant le cas (In/Ou). 
        /// </summary>
        public void Schedule()
        {
            try
            {
                //// Construct a scheduler factory
                ISchedulerFactory schedFact = new StdSchedulerFactory();

                //// Specify the sceduler task details
                JobDetail jobDetail = new JobDetail("SynchronisationJob", null, typeof(Job));

                Trigger trigger;

                // Read setting from XML file (For HL7)
                if (ReadXmlConfigFile())
                {
                    trigger = new CronTrigger("SynchronisationTrigger", "SynchronisationGroupe", GetCronExpressionFromXMLSetting());
                }
                else
                {

                    DateTime ts = TriggerUtils.GetNextGivenSecondDate(null, 15);
                    trigger = new SimpleTrigger("SynchronisationTrigger", "SynchronisationGroupe", ts);
                }

                //// schedule it
                IScheduler scheduler = schedFact.GetScheduler();
                scheduler.Start();
                scheduler.ScheduleJob(jobDetail, trigger);
            }
            catch (Exception)
            {
                //Logger.LogMessage(ex.Message, TraceType.Error);
            }
        }

        #endregion

        #region private methods

        /// <summary>
        /// Méthode renvoie l'expression Cron à partir du fichier XML
        /// </summary>
        /// <returns></returns>
        private string GetCronExpressionFromXMLSetting()
        {
            string seconds = XMLSettingEntity.InstanceConfig.Secondes;
            string minutes = XMLSettingEntity.InstanceConfig.Minutes;
            string hours = XMLSettingEntity.InstanceConfig.Heures;
            string daysOfMonth = XMLSettingEntity.InstanceConfig.JoursMois;
            string months = XMLSettingEntity.InstanceConfig.Mois;
            string daysOfWeek = XMLSettingEntity.InstanceConfig.JoursSemaine;

            string exp = seconds + " " + minutes + " " + hours + " " + daysOfMonth + " " + months + " " + daysOfWeek;

            try
            {
                //// Try to convert the expression on the cronExpression, to see if the exp is correct
                new CronExpression(exp);
            }
            catch (Exception)
            {
                // Logger.LogMessage(RsrMessages.ErrCronExpression, TraceType.Error, Destination.Synchro);
            }

            return exp;
        }

        /// <summary>
        /// ReadXmlFileHl7 : méthode sert à lire le fichier de configuration de l'application 
        /// Le fichier XML de configuration sert à sauvegarder les paramètres de l’application suivants : 
        /// 1. Périodicité de la synchronisation
        /// 2. Données relatives au segment MSH (en-tête du message)
        /// </summary>
        private bool ReadXmlConfigFile()
        {
            try
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG))
                {
                    if (XMLSettingEntity.InstanceConfig == null)
                    {
                        return false;
                    }
                    else
                        return true;
                }
                else
                {
                    //Logger.LogMessage(RsrMessages.ErrFichierIntrouvable + ":" + AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG, TraceType.Error, Destination.Synchro);
                    return false;
                }

            }
            catch (Exception ex)
            {
                Logger.LogMessage(ex.Message, TraceType.Error);
                return false;
            }
        }

        #endregion

    }
}
