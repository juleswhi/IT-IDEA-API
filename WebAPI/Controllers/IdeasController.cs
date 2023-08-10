using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdeasController : ControllerBase
    {
        private List<Idea> Ideas = new();
        private MySqlConnection conn = null;
        private string connStr = $"server=176.58.104.78;user=user;database=it_ideas;password=;";


        // GET: api/<IdeasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // Returns Names of all Ideas

            if(Ideas.Count != 0)
            {
                return Enumerable.Range(0, Ideas.Count).Select(x => Ideas[x].Name).ToList();
            }

            conn = new MySqlConnection(connStr);

            try { conn.Open(); } catch { return new string[] { "Failure" }; }


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
            return Enumerable.Range(0, Ideas.Count).Select(x => Ideas[x].Name).ToList();
        }

        // GET api/<IdeasController>/5
        [HttpGet("{id}")]
        public IEnumerable<string> Get(string id)
        {
            // Returns either, Name, Description, Id, Feasibility from Ideas
            List<string> list = new();

            if(conn == null)
            {
                Ideas = (List<Idea>)Idea.ReadInDB();
            }


            if (id.ToLower() == "name")
                return Enumerable.Range(0, Ideas.Count).Select(x => Ideas[x].Name).ToList();

            else if (id.ToLower() == "description")
                return Enumerable.Range(0, Ideas.Count).Select(x => Ideas[x].Description).ToList();

            else if (id.ToLower() == "id")
                return Enumerable.Range(0, Ideas.Count).Select(x => Ideas[x].Id.ToString()).ToList();

            else if (id.ToLower() == "feasibility")
                return Enumerable.Range(0, Ideas.Count).Select(x => Ideas[x].Feasibility.ToString()).ToList();


            return new string[] { "Please Enter a Valid Type" };

        }

        // POST api/<IdeasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {

        }

        // PUT api/<IdeasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // Adds an Idea
            Idea.AddIdea(value); 
        }

        // DELETE api/<IdeasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
