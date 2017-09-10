using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToMySQL.Entities.connectionString
{
    public class Mysql
    {
        public String _Server { get; set; }
        public String _Port { get; set; }
        public String _Database { get; set; }
        public String _User { get; set; }
        public String _Password { get; set; }
    }
}
