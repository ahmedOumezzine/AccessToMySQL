using AccessToMySQL.Entities.connectionString;
using AccessToMySQL.Entities.TypeChamp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AccessToMySQL.DataAccess.ADO.NET
{
   
    public class AdoDataAccess
    {
        private OleDbConnection connection;
        private Entities.TypeChamp.Attribute _Attribute;
        private Entities.TypeChamp.PrimaryAttribute _PrimaryAttribute;
        private Entities.TypeChamp.ForeignAttribute _ForeignAttribute;

        public string _source;
        public string _SystemDatabase;
        public string _DatabasePassword;
        public string _User;
        public string _Password;

        public AdoDataAccess(Ms_access dbMs_access)
        {
            _source = dbMs_access._Source;
            _SystemDatabase = dbMs_access._SystemDatabase;
            _DatabasePassword= dbMs_access._DatabasePassword;
            _User = dbMs_access._User;
            _Password=dbMs_access._Password;

        }

        public AdoDataAccess(){
        }

        //creation chaine de connection
        private string CreateConn()
        {
            string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + _source + ";";
            if (_SystemDatabase != "" && _DatabasePassword != "")
            {
                connectionString += " Jet OLEDB:System Database=" + _SystemDatabase + ";Jet OLEDB:Database Password=" + _DatabasePassword + ";";
            }
            if (_User != "" && _Password != "")
            {
                connectionString += "User ID=" + _User + ";Password=" + _Password + ";";
            }
            return connectionString;
        }

        //Initialize values
       private Boolean Initialize() {
            try
            {
                connection = new OleDbConnection(CreateConn());

            }
            catch (OleDbException e)
            {
                string msg = e.Message.ToString();
                return false;
            }
            return true;

        }

        //open connection to database
        private bool OpenConnection(){
            try
            {
                connection.Open();
                return true;
            }
            catch (OleDbException ex)
            {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.ErrorCode)
                {
                    case 0:
                        // MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        //  MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                string msg = ex.Message.ToString();
                return false;
            }
        }

        
        //Close connection
        private bool CloseConnection() {
            try
            {
                connection.Close();
                return true;
            }
            catch (OleDbException ex)
            {
                // MessageBox.Show(ex.Message);
                return false;
            }
        }


        private void GetTables(List<Table> arrTables)
        {
            // temporary holder for the schema information for the current
            // database connection
            DataTable SchemaTable;
            
            // make sure we have a connection
            if (Initialize())
            {
                // open the connection to the database 
                OpenConnection();
                // Get the Tables
                SchemaTable = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" });
                // Store the table names in the class scoped array list of table names
                for (int i = 0; i < SchemaTable.Rows.Count; i++)
                {
                    Table tab = new  Table();
                    tab._tableName = SchemaTable.Rows[i].ItemArray[2].ToString();
                    GetShemaTable(tab, tab._tableName);
                    arrTables.Add(tab);
                }
                CloseConnection();
            }

        }

        private void GetShemaTable(Table tab, string tblName)
        {
            DataTable tableColumns = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns, new object[] { null, null, tblName });
            foreach (DataRow row in tableColumns.Rows)
            {
                _Attribute = new Entities.TypeChamp.Attribute();
                _Attribute.name = row["COLUMN_NAME"].ToString();
                _Attribute.PositionColumn = Int32.Parse(row["ORDINAL_POSITION"].ToString());
                _Attribute.type = _Attribute.toStringType(Int32.Parse(row["DATA_TYPE"].ToString()));
                tab._arrAttribute.Add(_Attribute);
            }
            DataTable tablePrimary_Keys = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Primary_Keys, new object[] { null, null, tblName });
            foreach (DataRow row in tablePrimary_Keys.Rows)
            {
                _PrimaryAttribute = new PrimaryAttribute();
                _PrimaryAttribute._column_name = row["COLUMN_NAME"].ToString();
                _PrimaryAttribute._ordinalPositionColumn = Int32.Parse(row[6].ToString());
                tab._arrPrimaryAttribute.Add(_PrimaryAttribute);
            }
            DataTable tableForeign_Keys = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Foreign_Keys, new object[] { null, null, tblName });
            foreach (DataRow row in tableForeign_Keys.Rows)
            {
                _ForeignAttribute = new ForeignAttribute();
                _ForeignAttribute._column_name = row[3].ToString();
                _ForeignAttribute._Tabe_ref = row[8].ToString();
                _ForeignAttribute ._column_ref = row[9].ToString();
                _ForeignAttribute._ordinalPositionColumn = Int32.Parse(row[12].ToString());
                tab._arrForeignAttribute.Add(_ForeignAttribute);
            }
        }


    }
}
