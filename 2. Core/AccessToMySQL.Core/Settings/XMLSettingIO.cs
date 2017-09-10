using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessToMySQL.Infrastructure.Constantes;
using System.Xml.Linq;
using System.IO;


namespace AccessToMySQL.Core.Settings
{
    public class XMLSettingIO
    {
        #region fields
        /// <summary>
        /// sert à la gestion de lock des threads
        /// </summary>
        private static object obj = new object();

        #endregion

        #region public methods

        /// <summary>
        /// Méthode qui gère les params de planification
        /// </summary>
        /// <param name="secondes"></param>
        /// <param name="minutes"></param>
        /// <param name="heures"></param>
        /// <param name="jourSemaine"></param>
        /// <param name="jourMois"></param>
        /// <param name="mois"></param>
        public static void WritePlanification(string secondes, string minutes, string heures, string jourSemaine, string jourMois, string mois)
        {
            try
            {
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG))
                {
                    lock (obj)
                    {
                        XDocument xmlSynchroConfig = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
                        XElement configElmnt = xmlSynchroConfig.Element("config");
                        XElement planification = configElmnt.Element("Planification");

                        XElement xSecondes = planification.Elements("Secondes").Single();
                        XElement xMinutes = planification.Elements("Minutes").Single();
                        XElement xHeures = planification.Elements("Heures").Single();
                        XElement xJourSemaine = planification.Elements("JoursSemaine").Single();
                        XElement xJourMois = planification.Elements("JoursMois").Single();
                        XElement xMois = planification.Elements("Mois").Single();

                        if (string.IsNullOrEmpty(secondes))
                            xSecondes.Value = "0";
                        else
                            xSecondes.Value = @"0/" + secondes;

                        if (string.IsNullOrEmpty(minutes))
                            xMinutes.Value = "0";
                        else
                            xMinutes.Value = @"0/" + minutes;

                        if (string.IsNullOrEmpty(heures))
                            xHeures.Value = "*";
                        else
                            xHeures.Value = @"0/" + heures;

                        if (string.IsNullOrEmpty(jourSemaine))
                            xJourSemaine.Value = "?";
                        else
                        {
                            xJourSemaine.Value = jourSemaine;
                            if (!string.IsNullOrEmpty(heures))
                            {
                                xHeures.Value = heures;
                            }
                        }

                        if (string.IsNullOrEmpty(jourMois))
                            xJourMois.Value = "*";
                        else
                            xJourMois.Value = jourMois;

                        if (string.IsNullOrEmpty(mois))
                            xMois.Value = "*";
                        else
                            xMois.Value = mois;

                        xmlSynchroConfig.Save(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
                        XMLSettingEntity.InstanceConfig.Secondes = xSecondes.Value;
                        XMLSettingEntity.InstanceConfig.Minutes = xMinutes.Value;
                        XMLSettingEntity.InstanceConfig.Heures = xHeures.Value;
                        XMLSettingEntity.InstanceConfig.JoursSemaine = xJourSemaine.Value;
                        XMLSettingEntity.InstanceConfig.JoursMois = xJourMois.Value;
                        XMLSettingEntity.InstanceConfig.Mois = xMois.Value;
                    }
                }
            }
            catch (Exception)
            {
                //loggerApp.LogMessage(ex.Message, TraceType.Error);

            }
        }

        #endregion
    }
}
