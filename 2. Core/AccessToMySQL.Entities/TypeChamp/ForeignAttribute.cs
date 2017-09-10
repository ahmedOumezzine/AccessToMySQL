using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToMySQL.Entities.TypeChamp
{
     public class ForeignAttribute
    {
        public string _column_name { get; set;}
        public string _column_ref { get; set; }
        public int _ordinalPositionColumn { get; set; }
        public string _Tabe_ref { get; set; }
    }
}
