using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NLP_PAL_Project.Models
{
    public class GptRequestMessageObject
    {
        public string role { get; set; }
        public string content { get; set; }
    }
}
