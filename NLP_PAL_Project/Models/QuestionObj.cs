using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLP_PAL_Project.Models
{
    public class QuestionObj
    {
        public int Id { get; set; }
        public string Intro { get; set; }
        public string ExampleQuestion { get; set; }
        public string ExampleAnswer { get; set; }
        public string RealQuestion { get; set; }
    }
}
