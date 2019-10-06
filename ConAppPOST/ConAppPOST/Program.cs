using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConAppPOST
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
            //string strUrl = string.Format("http://localhost:10257/api/values");
            //WebRequest requestObjPost = WebRequest.Create(strUrl);

            //requestObjPost.Credentials = CredentialCache.DefaultCredentials;
            //requestObjPost.Method = "POST";
            //requestObjPost.ContentType = "application/json";

            //string postOata = "{\"title\":\"WebForm\"}";
            //StreamWriter streamWriter = new StreamWriter(requestObjPost.GetRequestStream());

            //    streamWriter.Write(postOata);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            GetPostAsync().GetAwaiter().GetResult();

        }

        //https://stackoverflow.com/questions/4015324/how-to-make-http-post-web-request
        public static async Task GetPostAsync()
        {
            var values = new Dictionary<string, string>
{
{"title", "WebForm"}
};

            var content = new FormUrlEncodedContent(values);

            var response = await client.PostAsync("http://localhost:10257/api/values", content);

            var responseString = await response.Content.ReadAsStringAsync();
        }
    }
}



