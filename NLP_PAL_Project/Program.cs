using NLP_PAL_Project.Models;

namespace NLP_PAL_Project
{  
    class Program
    {
        public static async Task Main(string[] args)
        {
            Consts.Init();
            // Read all prompt data - Bar
            List<QuestionObj> questionObjs = new List<QuestionObj> {
                new QuestionObj
                {
                    Id = 1,
                    Intro = "test",
                    ExampleQuestion = "q",
                    ExampleAnswer = "a",
                    RealQuestion= "qq",
                },
                new QuestionObj
                {
                    Id = 2,
                    Intro = "test",
                    ExampleQuestion = "q",
                    ExampleAnswer = "a",
                    RealQuestion= "qq",
                },
                new QuestionObj
                {
                    Id = 3,
                    Intro = "test",
                    ExampleQuestion = "q",
                    ExampleAnswer = "a",
                    RealQuestion= "qq",
                },
            };

           
            // Execute code on compilers - Denis

            // Get answers from compilers and give scores to languages

            // Graphs, stats, etc.
        }
    }
}