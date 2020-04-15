using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Sample_Code_Example_Projects
{
    class StoredProcW_INTReturn
    {
        public static int RunStoredProcedure(string UserInput)
        {
            int Count;
            SqlConnection connection = DbConnection.GetConnection();
            using (SqlCommand cmd = new SqlCommand("spSPWithOutputINT", connection))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                // set up the parameters
                cmd.Parameters.Add("@Input", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@ret_value", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@Input"].Value = UserInput;

                // open connection and execute stored procedure
                connection.Open();
                cmd.ExecuteNonQuery();

                // read output value from @ret_value
                Count = Convert.ToInt32(cmd.Parameters["@ret_value"].Value);
                connection.Close();
                return Count;
            }
        }
    }
}
