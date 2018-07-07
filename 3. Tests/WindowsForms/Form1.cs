using AccessToMySQL.DataAccess.CommonInterface;
using AccessToMySQL.Entities.connectionString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAccessTest_Click(object sender, EventArgs e)
        {
            Ms_access ac = new Ms_access();
            ac._Provider = txtAccessProvider.Text;
            ac._Source = txtAccessDBname.Text;
            ac._User = txtAccessUserID.Text;
            ac._Password = txtAccessPassword.Text;
            ac._SystemDatabase = txtAccessSystemDB.Text;
            ac._DatabasePassword = txtAccessDatabasePassword.Text;
            

            Mysql am = new Mysql();
            am._Server = txtMysqlHost.Text;
            am._Port = txtMysqlPort.Text;
            am._User = txtMysqlUserID.Text;
            am._Password = txtMysqlPassword.Text;
            am._Database = txtMysqlDatabase.Text;

            home op = new home(ac, am);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "MS Access Database";
            openFile.DefaultExt = "mdb";
            openFile.Filter = "Access Database (*.mdb)|*mdb";
            openFile.ShowDialog();
            txtAccessDBname.Text = openFile.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "System DB Database";
            openFile.DefaultExt = "mdw";
            openFile.Filter = "System DB  (*.mdw)|*mdw";
            openFile.ShowDialog();
            txtAccessSystemDB.Text = openFile.FileName;
        }

        private void btnAccessOK_Click(object sender, EventArgs e)
        {

        }
    }
}
