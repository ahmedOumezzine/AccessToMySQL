using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessToMySQL.Entities.TypeChamp
{
    public class Attribute
    {
        public string name { get; set; }
        public string type { get; set; }
        public int PositionColumn { get; set; }



        public string toStringType(int type)
        {
            switch (type)
            {
                case 0: return "Nullable";
                case 2: return "INTEGER";
                case 3: return "INTEGER";
                case 4: return "Single";
                case 5: return "Double";
                case 6: return "decimal(19,4)";
                case 7: return "DateTime";
                case 8: return "strinf";
                case 9: return "Object";
                case 11: return "Boolean";
                case 12: return "Object";
                case 13: return "Object";
                case 14: return "Decimal";
                case 16: return "SByte";
                case 17: return "Byte";
                case 18: return "UInt16";
                case 19: return "UInt32";
                case 20: return "Int64";
                case 21: return "UInt64";
                case 64: return "DateTime";
                case 72: return "Guid";
                case 128: return "Byte[]";
                case 129: return "longtext";
                case 130: return "longtext";
                case 131: return "Decimal";
                case 133: return "DateTime";
                case 134: return "TimeSpan";
                case 135: return "DateTime";
                case 138: return "Object";
                case 139: return "Decimal";
                case 200: return "longtext";
                case 201: return "longtext";
                case 202: return "longtext";
                case 203: return "longtext";
            }
            throw (new Exception("DataType Not Supported"));
        }

        /*
        public string toStringType2(int type)
        {
            switch (type)
            {
                case 0: return "Nullable";
                case 2: return "int";
                case 3: return "int";
                case 4: return "Single";
                case 5: return "Double";
                case 6: return "Decimal";
                case 7: return "DateTime";
                case 8: return "strinf";
                case 9: return "Object";
                case 11: return "Boolean";
                case 12: return "Object";
                case 13: return "Object";
                case 14: return "Decimal";
                case 16: return "SByte";
                case 17: return "Byte";
                case 18: return "UInt16";
                case 19: return "UInt32";
                case 20: return "Int64";
                case 21: return "UInt64";
                case 64: return "DateTime";
                case 72: return "Guid";
                case 128: return "Byte[]";
                case 129: return "string";
                case 130: return "string";
                case 131: return "Decimal";
                case 133: return "DateTime";
                case 134: return "TimeSpan";
                case 135: return "DateTime";
                case 138: return "Object";
                case 139: return "Decimal";
                case 200: return "string";
                case 201: return "string";
                case 202: return "string";
                case 203: return "string";
            }
            throw (new Exception("DataType Not Supported"));
        }

        */
    }
}
