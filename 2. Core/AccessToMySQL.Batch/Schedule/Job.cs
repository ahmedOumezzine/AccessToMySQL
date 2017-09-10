using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using AccessToMySQL.Infrastructure.Tools;
using Quartz;
using AccessToMySQL.Core.Synchronizer;

namespace AccessToMySQL.Batch.Schedule
{
    public class Job : IJob
    {

        static Thread threadSynchro;
        /// <summary>
        /// Implémentation de la méthode Excute de IJob
        /// </summary>
        /// <param name="context"></param>
        public void Execute(JobExecutionContext context)
        {
            ThreadStart synchro = new ThreadStart(Synchronizer.Synchronize);
            if (threadSynchro == null || !threadSynchro.IsAlive)
            {
                threadSynchro = new Thread(synchro);
                threadSynchro.Start();
            }
            else
            {
                Logger.LogMessage("Witing", TraceType.Info);
            }
        }


    }
}
