using AccessToMySQL.Infrastructure.Constantes;
using AccessToMySQL.Infrastructure.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AccessToMySQL.Core.Synchronizer
{
    public class Synchronizer
    {
        #region Fields

        private static object lockSynchro = new object();
        private static object lockSynchroBack = new object();

        #endregion

        /// <summary>
        /// 
        /// </summary>
        public static void Synchronize()
        {
            try
            {
                lock (lockSynchro)
                {
                    Logger.LogMessage("      LANCEMENT DE L'APPLICATION     ", TraceType.Info);
                   // DataAccessServicesOut.RemplirAllTablesOuts();

                  //  DataAccessServicesIN.MiseAjourFuturaWithTablesIns();
                    Logger.LogMessage("      FIN DE L'EXECUTION       " + Globals.RETOURLIGNE, TraceType.Info);

                }
            }
            catch (Exception ex)
            {
                Logger.LogMessage(ex.Message, TraceType.Error);
            }
        }

    }
}
