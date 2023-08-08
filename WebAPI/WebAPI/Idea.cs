using MySql.Data.MySqlClient;

namespace WebAPI
{
    public class Idea
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Feasibility { get; set; }



        public static IEnumerable<Idea> ReadInDB()
        {
            List<Idea> Ideas = new();
            string password = "";
            string connStr = $"server=176.58.104.78;user=user;database=it_ideas;password={password};";

            MySqlConnection conn = new MySqlConnection(connStr);

            conn.Open();

            string sql = "select * from Ideas";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            MySqlDataReader reader = cmd.ExecuteReader();


            while (reader.Read())
            {
                Ideas.Add(
                    new Idea()
                    {
                        Id = (int)reader["id"],
                        Name = (string)reader["Name"],
                        Description = (string)reader["Description"],
                        Feasibility = (int)reader["Feasibility"]
                    });
            }

            conn.Close();
            return Ideas;

        }

    }
}
