using AnimalFarm.DAL.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFarm.DAL.DAO
{
    internal class CattleDAO
    {
        public static void LoadCattleInformation(ref Cattle cattle, string type)
        {
            string connectionString = Connection.getConnectionString();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM CATTLE WHERE typeName = '" + type + "'";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            float minMilk = Convert.ToSingle(reader["minMilk"]);
                            float maxMilk = Convert.ToSingle(reader["maxMilk"]);
                            string sound = reader["sound"].ToString();

                            cattle = new Cattle(id,type,minMilk,maxMilk,sound);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
