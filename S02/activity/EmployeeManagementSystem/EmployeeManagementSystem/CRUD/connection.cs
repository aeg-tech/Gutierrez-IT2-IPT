using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.CRUD
{
    class connection
    {
        static string dbPath = @"C:\LOCALDB\EMS.mdb";
        public static string conString = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={dbPath};";
        

        public static OleDbConnection mysqldb()
        {
            return new OleDbConnection(conString);
        }
        public static OleDbConnection con = mysqldb();
    }
}
