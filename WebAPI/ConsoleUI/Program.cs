using MySql.Data.MySqlClient;

var password = "Pawelek6992425#";
var connString = $"server=176.58.104.78;user=user;database=it_ideas;password={password};";


MySqlConnection conn = new MySqlConnection(connString);

conn.Open();

string sql = "SELECT * FROM Ideas";

MySqlCommand cmd = new MySqlCommand(sql, conn);

MySqlDataReader reader = cmd.ExecuteReader();
List<MySqlDataReader> IdeaNames = new();
while (reader.Read())
{
    IdeaNames.Add(reader); 
}
Console.WriteLine(IdeaNames[1]["Name"]);
reader.Close();

