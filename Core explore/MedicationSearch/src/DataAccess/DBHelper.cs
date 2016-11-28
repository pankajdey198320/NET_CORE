using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DBHelper
    {
        private static string connectionString = @"Data Source=10.106.17.152\INTN1;Initial Catalog=CheetahINT;Integrated Security=True;"; //Your connection string
       
        public static string[] QueryMeds(string searchText, int rowCount, string genericEquivalent)
        {
            List<SqlParameter> paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@searchtext", searchText));
            paramList.Add(new SqlParameter("@rowcount", rowCount));
            paramList.Add(new SqlParameter("@genericEquivalent", genericEquivalent));
            var sarray = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // 1.  create a command object identifying the stored procedure
                SqlCommand cmd = new SqlCommand("querymeds", conn);

                // 2. set the command object so it knows to execute a stored procedure
                cmd.CommandType = CommandType.StoredProcedure;

                // 3. add parameter to command, which will be passed to the stored procedure
                cmd.Parameters.Add(new SqlParameter("@searchtext", searchText));
                cmd.Parameters.Add(new SqlParameter("@rowcount", rowCount));
                cmd.Parameters.Add(new SqlParameter("@genericEquivalent", genericEquivalent));

               
                // execute the command
                using (var rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read())
                    {
                        sarray.Add(rdr["Name"].ToString());
                    }
                }
            }
            return sarray.ToArray();
        }
    }
}
