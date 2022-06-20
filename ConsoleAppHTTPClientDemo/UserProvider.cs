using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConsoleAppHTTPClientDemo
{
    class UserProvider
    {
        public static User GetDataById(String id)
        {
            User user = new User();
            Uri url = new Uri("https://62ad56ae402135c7acbf606a.mockapi.io/users/"+id);
            using (var client = new HttpClient())
            {
                var request = client.GetAsync(url).GetAwaiter().GetResult();
                if (request.IsSuccessStatusCode)
                {
                    string responString = request.Content.ReadAsStringAsync().Result;
                    user = JsonConvert.DeserializeObject<User>(responString);                    
                }
            }
            return user;
        }

        public static HttpResponseMessage CreateData(User user)
        {
            using (HttpClient client = new HttpClient())
            {
                string userJson = JsonConvert.SerializeObject(user);
                //Console.WriteLine(userJson);

                StringContent stringContent = new StringContent(
                    userJson,
                    Encoding.UTF8,
                    "application/json"
                    );
                string url = "https://62ad56ae402135c7acbf606a.mockapi.io/users/";
                HttpResponseMessage request = client.PostAsync(url, stringContent).Result;
                return request;
            }
        }
    }
}
