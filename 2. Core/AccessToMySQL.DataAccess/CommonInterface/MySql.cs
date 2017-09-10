using AccessToMySQL.Entities.TypeChamp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessToMySQL.DataAccess.ADO.NET;
using AccessToMySQL.Entities.connectionString;
using MySql.Data.MySqlClient;
using System.IO;

namespace AccessToMySQL.DataAccess.CommonInterface
{
    public class MySql
    {
        private List<Table> arrTables;
        private AdoDataMysql op;

        public MySql(Mysql dbMs_access) {
            op = new AdoDataMysql(dbMs_access);
        }

        public void Restore(string path)
        {
            op.Restore(path);
        }
        public MySqlDataReader Select(string query)
        {
           return op.Select(query);
        }

        public void createSQL(string text2write)
        {
            op.createSQL(text2write);
        }


        }


}

