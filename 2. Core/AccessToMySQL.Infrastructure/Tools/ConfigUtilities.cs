using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Linq;
using AccessToMySQL.Infrastructure.Constantes;

namespace AccessToMySQL.Infrastructure.Tools
{
    public class ConfigUtilities
    {
        public ConfigUtilities()
        {

        }
        public static string GetConfigElementValue(string racineElement, string filsElement)
        {
            string result = string.Empty;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG))
            {
                XDocument xmlSynchroConfig = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
                XElement configElmnt = xmlSynchroConfig.Element("config");
                if (configElmnt.Element(racineElement) != null)
                {
                    XElement InterfaceElmnt = configElmnt.Element(racineElement);
                    if (InterfaceElmnt.Element(filsElement) != null)
                    {
                        result = InterfaceElmnt.Element(filsElement).Value;
                    }
                }
            }

            return result;
        }

        public static bool ExistElement(string racineElement, string filsElement)
        {
            bool result = false;
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG))
            {
                XDocument xmlSynchroConfig = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
                XElement configElmnt = xmlSynchroConfig.Element("config");
                if (configElmnt.Element(racineElement) != null)
                {
                    XElement interfaceElmnt = configElmnt.Element(racineElement);
                    result = (interfaceElmnt.Element(filsElement) != null);
                }
            }

            return result;
        }

        public static void SetConfigElementValue(string racineElement, string filsElement, string value)
        {
            if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG))
            {
                XDocument xmlSynchroConfig = XDocument.Load(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
                XElement configElmnt = xmlSynchroConfig.Element("config");
                XElement hl7Elmnt = configElmnt.Element(racineElement);
                hl7Elmnt.Element(filsElement).Value = value;
                xmlSynchroConfig.Save(AppDomain.CurrentDomain.BaseDirectory + "/" + Globals.SYNCHRO_CONFIG);
            }
        }
    }
}
