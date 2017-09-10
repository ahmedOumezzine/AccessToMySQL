using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessToMySQL.Entities.connectionString;

namespace AccessToMySQL.DataAccess.CommonInterface
{
     public class home
    {
        MySql ms;
        MsAccess access;
       

        public home(Ms_access ac, Mysql am)
        {   
            access = new MsAccess(ac);
            ms = new MySql(am);
        }
        public void run() {
            access.getShemaDatabase();
            access.GeShemaTables();
            
        }
    }
}
