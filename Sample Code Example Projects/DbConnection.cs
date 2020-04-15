using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sample_Code_Example_Projects
{
    class DbConnection
    {
        public static SqlConnection GetConnection()
        {

            string connectionString =
                "Data Source = ATTIC-PC; Initial Catalog = SampleCodeEg;" +
                "Persist Security Info = True;" +
                "User ID = sa; Password = 7644691";
            // "Data Source=localhost\\MSSQLSERVER2012;Initial Catalog=CISDB;" +
            //"Integrated Security = True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

    }
}
