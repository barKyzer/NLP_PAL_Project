using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Collections.Generic;

namespace NLP_PAL_Project.Models
{
    public class RequestCompletionParam
    {
        public string Intro { get; set; }
        public string ExampleQuestion { get; set; }
        public string ExampleAnswer { get; set; }
        public string RealAnswer { get; set; }
        
    }
}
