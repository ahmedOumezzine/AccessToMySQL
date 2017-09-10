using AccessToMySQL.Entities.connectionString;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToMySQL.DataAccess.ADO.NET
{
    class AdoDataMysql
    {
        private MySqlConnection connection;
        private Entities.TypeChamp.Attribute _Attribute;
        private Entities.TypeChamp.PrimaryAttribute _PrimaryAttribute;
        private Entities.TypeChamp.ForeignAttribute _ForeignAttribute;

        public string _server;
        public string _SystemDatabase;
        public string _Port;
        public string _User;
        public string _Password;

        public AdoDataMysql(Mysql dbMs_access)
        {
            _server = dbMs_access._Server;
            _Port = dbMs_access._Port;
            _SystemDatabase = dbMs_access._Database;
            _User = dbMs_access._User;
            _Password = dbMs_access._Password;

        }
        #region private method
        public AdoDataMysql(){
        }

        //creation chaine de connection
        private string CreateConn()
        {
            string connectionString = "SERVER=" + _server + ":"+ _Port + ";" + "DATABASE=" + _SystemDatabase + ";" + "UID=" + _User + ";" + "PASSWORD=" + _Password + ";";

            return connectionString;
        }

        //Initialize values
        private Boolean Initialize()
        {
            try
            {
                connection = new MySqlConnection(CreateConn());

            }
            catch (MySqlException e)
            {
                string msg = e.Message.ToString();
                return false;
            }
            return true;

        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
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
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                // MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void create(string path, string text2write){
            System.IO.StreamWriter writer = new System.IO.StreamWriter(path);
            writer.Write(text2write);
            writer.Close();
        }

        private void Check(string path){
            string[] files = Directory.GetFiles(path);

            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                if (fi.LastAccessTime < DateTime.Now.AddHours(-5))
                    fi.Delete();
            }
        }


        #endregion

        public MySqlDataReader Select(string query)
        {
            this.OpenConnection();
            //Create Command
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();
            //close Connection
            this.CloseConnection();
            return dataReader;

        }

        #region Restore
        public void Restore(string path)
        {
            try
            {
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();


                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}", _User, _Password, _server+":"+_Port, _SystemDatabase);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                //MessageBox.Show("Error , unable to Restore!");
            }
        }
        #endregion

        #region create SQL 
        public void createSQL(string text2write)
        {
            string result = Path.GetTempPath();
            create(result + "/AccessToMySQL", text2write);
            Check(result + "/AccessToMySQL");
        }
        #endregion
    }
}
