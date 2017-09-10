using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToMySQL.Entities.TypeChamp
{
    public class Table
    {
        public string _tableName { get; set; }
        public List<Attribute> _arrAttribute = new List<Attribute>();
        public List<PrimaryAttribute> _arrPrimaryAttribute = new List<PrimaryAttribute>();
        public List<ForeignAttribute> _arrForeignAttribute = new List<ForeignAttribute>();

    }
}
