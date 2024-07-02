using System;

namespace NLP_PAL_Project
{  
    class Program
    {
        public static async Task Main(string[] args)
        {
            var ret = await Utils.MakeRequest(HttpMethod.Get, "https://httpbin.org/get");
            Console.WriteLine(ret);
        }
    }
}