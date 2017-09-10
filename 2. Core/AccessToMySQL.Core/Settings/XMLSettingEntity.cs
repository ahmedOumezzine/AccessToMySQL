using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccessToMySQL.Infrastructure.Constantes;
using System.Xml.Linq;
using System.IO;

namespace AccessToMySQL.Core.Settings
{
    public class XMLSettingEntity
    {
        #region fields
        ///Singleton
        private static XMLSettingEntity instanceConfig = null;

        #endregion

        #region constructors
        /// <summary>
        /// Constructeur privé pour ne pas instancier la classe depuis l'exterieur
        /// </summary>
        private XMLSettingEntity()
        {
        }
        #endregion

        #region properties


        #region Planification
        public string Secondes { get; set; }
        public string Minutes { get; set; }
        public string Heures { get; set; }
        public string JoursMois { get; set; }
        public string Mois { get; set; }
        public string JoursSemaine { get; set; }
        #endregion

        #region Chemins des Repertoires
        public Dictionary<string, string> Repertoires { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        public string DernierNumero { get; set; }

        public string Prefixe { get; set; }

        public static XMLSettingEntity InstanceConfig
        {
            get
            {
                if (instanceConfig == null)
                {
                    ReadXmlConfigFile();
                }
                return instanceConfig;
            }

        }


        #endregion

        #region methods

        /// <summary>
        /// Méthode s'occupe de la lecture de fichier XML
        /// </summary>
        private static void ReadXmlConfigFile()
        {
            try
            {
                instanceConfig = new XMLSettingEntity();
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG))
                {
                    XDocument xmlSynchroConfig = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
                    //// Config Element
                    XElement configElmnt = xmlSynchroConfig.Element("config");

                    //// Planification Element
                    XElement planElmnt = configElmnt.Element("Planification");
                    instanceConfig.Secondes = string.IsNullOrEmpty(planElmnt.Element("Secondes").Value) ? "*" : planElmnt.Element("Secondes").Value;
                    instanceConfig.Minutes = string.IsNullOrEmpty(planElmnt.Element("Minutes").Value) ? "*" : planElmnt.Element("Minutes").Value;
                    instanceConfig.Heures = string.IsNullOrEmpty(planElmnt.Element("Heures").Value) ? "*" : planElmnt.Element("Heures").Value;
                    instanceConfig.JoursMois = string.IsNullOrEmpty(planElmnt.Element("JoursMois").Value) ? "*" : planElmnt.Element("JoursMois").Value;
                    instanceConfig.Mois = string.IsNullOrEmpty(planElmnt.Element("Mois").Value) ? "*" : planElmnt.Element("Mois").Value;
                    instanceConfig.JoursSemaine = string.IsNullOrEmpty(planElmnt.Element("JoursSemaine").Value) ? "*" : planElmnt.Element("JoursSemaine").Value;


                }
                else
                {
                    //Logger.LogMessage(MessagesHl7.ErrFichierIntrouvable + ":" + AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG, TraceType.Error, Destination.Synchro);
                }

            }
            catch (Exception)
            {
                //Logger.LogMessage(ex.Message, TraceType.Error);
            }
        }



        #endregion
    }
}
