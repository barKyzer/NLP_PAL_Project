using NLP_PAL_Project.Models;

namespace NLP_PAL_Project
{  
    class Program
    {
        public static async Task Main(string[] args)
        {
            Consts.Init();
            // Read all prompt data - Bar
            List<QuestionObj> list = new List<QuestionObj>();

            // Send prompt to GPT and get code - Dan

            // Execute code on compilers - Denis

            // Get answers from compilers and give scores to languages

            // Graphs, stats, etc.

            var ret = await GptLogic.ProcessCompletionRequest(new Models.RequestCompletionParam());
            Console.WriteLine(ret);
        }
    }
}