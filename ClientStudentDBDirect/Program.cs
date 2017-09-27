using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientStudentDBDirect
{
    class Program
    {
        static void Main(string[] args)
        {
            string selectAllStudent = "select * from student";

            string conn = "Server = tcp:annesazure.database.windows.net,1433; Initial Catalog = EasjDBasw; Persist Security Info = False; User ID = anne55x9; Password = Easj2017; MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";

            using (SqlConnection databaseConnection = new SqlConnection(conn))
            {
                databaseConnection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectAllStudent, databaseConnection))
                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string name = reader.GetString(1);
                            
                            
                            Console.WriteLine(id + name);
                        } 
                    }
                    
                }
            }

            Console.ReadLine();
        }
    }
}
