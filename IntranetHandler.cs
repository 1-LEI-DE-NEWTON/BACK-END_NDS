using System;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api-h-2.intranet.maracanau.ifce.edu.br/auth/login";
            //Get username and password from console
            Console.WriteLine("Username: ");
            string username = Console.ReadLine();
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();
            //Create json object
            string json = "{\"identificacao\":\"" + username + "\",\"senha\":\"" + password + "\"}";
            //Create web request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json";
            //Send json object
            byte[] byteArray = Encoding.UTF8.GetBytes(json);
            request.ContentLength = byteArray.Length;
            using (var dataStream = request.GetRequestStream())
            {
                dataStream.Write(byteArray, 0, byteArray.Length);
            }
            //Get response
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string responseString = new System.IO.StreamReader(response.GetResponseStream()).ReadToEnd();
            //Deserialize json
            Token jwt = JsonConvert.DeserializeObject<Token>(responseString);
            //Get token
            string tokenString = jwt.data.token;
            //Decode token
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(tokenString) as JwtSecurityToken;            
            string pessoa_tipo_id = jsonToken.Claims.First(claim => claim.Type == "pessoa_tipo_id").Value;
            Console.WriteLine("PessoaTipoId: " + pessoa_tipo_id);
            //Check if pessoa_tipo_id is 1
            if (pessoa_tipo_id == "1")
            {
                Console.WriteLine("Aluno");
            }
        }
    }

    public class DataToken
    {
        public string token { get; set; }
    }

    public class Token
    {
        public DataToken data { get; set; }
    }
}
