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
    public class MsAccess
    {
        private List<Table> arrTables;
        private AdoDataAccess op;

        public MsAccess(Ms_access dbMs_access) {
            op = new AdoDataAccess(dbMs_access);
        }
        

        public void getShemaDatabase()
        {
            arrTables = new List<Table>();
            op.GetTables(arrTables);
        }

        public void GeShemaTables()
        {
            foreach(Table tab in arrTables)
            {
                CreateTable(tab);
                GetRow(tab);
            }
           
        }


        #region private method
        private string CreateTable(Table tab)
        {
            string sql=  "\n #"
                       + "\n # Table structure for table '" + tab._tableName + "'"
                       + "\n #";
                
            sql += "\n DROP TABLE IF EXISTS `" + tab._tableName+ "` ;";
            #region create Table
                sql += "\n CREATE TABLE  `" + tab._tableName + "` (";
                // create attrible 
                #region attrible
                int count0 = tab._arrAttribute.Count();
                if (count0 != 0) {
                    var list0 = tab._arrAttribute.OrderBy(i => i.PositionColumn).ToList();
                    for (int i = 0; i < count0; i++)
                    {
                        sql += "\n "+ list0[i].name + " " + list0[i].type +",";
                    }
                    sql = sql.Remove(sql.Length - 1);
                }
                #endregion
                // add primary attrible
                #region primary attrible
                int count = tab._arrPrimaryAttribute.Count();
                if (count != 0) { 
                    var list = tab._arrPrimaryAttribute.OrderBy(i => i._ordinalPositionColumn).ToList();
                    for (int i = 0; i < count; i++)
                    {
                        sql += ",\n  PRIMARY KEY (`"+ list[i]._column_name+ "`),";
                    }
                    sql = sql.Remove(sql.Length - 1);
                }
                #endregion
                // add Foreign attrible
                #region Foreign attrible
                int count2 = tab._arrForeignAttribute.Count();
                if (count2 != 0) { 
                    var list2 = tab._arrForeignAttribute.OrderBy(i => i._ordinalPositionColumn).ToList();
                    for (int i = 0; i < count2; i++)
                    {
                        sql += ",\n FOREIGN KEY ("+ list2[i]._column_name+ ") REFERENCES " + list2[i]._Tabe_ref + "(" + list2[i]._column_ref + "),";
                    }
                    sql = sql.Remove(sql.Length - 1);
                }
                #endregion
                sql += "\n )";
            #endregion

            return sql;
        }

        private string GetRow(Table tab)
        {

          //  MySqlDataReader dataReader= op.getRow(tab);
            string sql = "#"
                       + "# Dumping data for table'"+tab._tableName+"'"
                       + "# \n";
            int count = tab._arrAttribute.Count();
            var list = tab._arrForeignAttribute.OrderBy(i => i._ordinalPositionColumn).ToList();
            for (int i = 0; i < count; i++)
            {
                sql = "INSERT INTO `" + tab._tableName + "` () VALUES ();";
            }
            return "";
        }
        #endregion

        
    }
}
