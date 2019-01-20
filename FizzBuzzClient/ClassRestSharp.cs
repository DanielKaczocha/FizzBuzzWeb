using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzClient
{
    public class ClassRestSharp
    {
        public void TestRestSharp()
        {
            var client = new RestClient("https://localhost:44319");
            var request = new RestRequest("api/values/{id}", Method.GET);
            request.AddParameter("id", 1);

            var content = client.Execute(request).Content;
        }
    }
}
