
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ConsoleUI
{


    public class DBConnection
    {

        public static MySqlConnection connMaster = new MySqlConnection();

        static string server = "176.58.104.78;";
        static string database = "it_ideas;";
        static string Uid = "user;";
        static string password = "Pawelek6992425#;";

        public static MySqlConnection dataSource()
        {
            connMaster = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return connMaster;
        }


        public void connOpen()
        {
            dataSource();
            connMaster.Open();
        }


        public void connClose()
        {
            dataSource();
            connMaster.Close();
        }



    }
}


