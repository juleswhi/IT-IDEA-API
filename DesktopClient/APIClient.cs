using System.Net.Http.Headers;
using IT_IDEA_DESKTOP.Forms;
namespace IT_IDEA_DESKTOP
{
    internal static class APIClient
    {
        private const string URL = "http://itidea.site/api/";

        public static async Task<List<string>> GetNamesAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
            HttpResponseMessage response = client.GetAsync("Ideas/name").Result;

            string strRes = (await response.Content.ReadAsStringAsync()).ToString();


            string str = "";
            for(int i = 1; i < strRes.Length - 1; i++)
            {
                if (strRes[i] == '\"')
                    continue;
                str = $"{str}{strRes[i]}";
            }

            return str.Split(',').ToList();


            // Parse Response
            // remove ] 
        }
        public static async Task<List<string>> GetDescriptionsAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
            HttpResponseMessage response = client.GetAsync("Ideas/description").Result;

            string strRes = (await response.Content.ReadAsStringAsync()).ToString();


            string str = "";
            for(int i = 1; i < strRes.Length - 1; i++)
            {
                if (strRes[i] == '"')
                    continue;
                str = $"{str}{strRes[i]}";
            }

            return str.Split(',').ToList();
        }
        public static async Task<List<string>> GetFeasibilityAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
            HttpResponseMessage response = client.GetAsync("Ideas/feasibility").Result;

            string strRes = (await response.Content.ReadAsStringAsync()).ToString();

            // Parse Response
            // remove ] 
             string str = "";
            for(int i = 1; i < strRes.Length - 1; i++)
            {
                if (strRes[i] == '\"')
                    continue;
                str = $"{str}{strRes[i]}";
            }

            return str.Split(',').ToList();
        }

        public static async Task<List<Idea>> GetIdeasAsync()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

            HttpResponseMessage response = client.GetAsync("Ideas/id").Result;
            string strRes = (await response.Content.ReadAsStringAsync()).ToString();


            string str = "";
            for(int i = 1; i < strRes.Length - 1; i++)
            {
                if (strRes[i] == '\"')
                    continue;
                str = $"{str}{strRes[i]}";
            }

            List<string> idData = str.Split(',').ToList();
            List<string> nameData = await GetNamesAsync();
            List<string> descData = await GetDescriptionsAsync();
            List<string> feasData = await GetFeasibilityAsync();

            List<Idea> ideas = new();

            for(var i = 0; i < idData.Count; i++)
            {
                ideas.Add(
                    new Idea()
                    {
                        Id = idData[i],
                        Name = nameData[i],
                        Description = descData[i],
                        Feasibility = feasData[i]
                    });
            }
            IdeaHolder.Ideas = ideas;
            return ideas;

        }


        private static List<string> dataToStringList(string Data)
        {
            string strData = "";
            for(var i = 1; i < strData.Length - 1; i++)
            {
                strData = $"{strData}{Data[i]}";
            }
            return strData.Split(',').ToList();
        }
    }
}
