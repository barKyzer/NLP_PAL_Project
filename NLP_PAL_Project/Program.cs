using System;

using NLP_PAL_Project.Models;
namespace NLP_PAL_Project
{  
    class Program
    {
        public static async Task Main(string[] args)
        {
            //Consts.Init();
            // Read all prompt data - Bar
            List<QuestionObj> questionObjs = await ReadQuestionsFromJsonAsync("/mnt/data/test.jsonl");

            //dynamic[] codeSnippets = await GptLogic.GeneratePalAnswers(questionObjs);

            // Execute code on compilers - Denis
            
            CodeExecutor codeExecutor= new CodeExecutor();
            string pythonCode = "print(\"this is python code\")";
            string JSCode = "console.log('this is java script code');";
            string CSharpCode = @"
        using System;

        public class Program
        {
            public static string Main()
            {
                return ""This is C# code"";
            }
        }
        Program.Main();
    ";
            string CSharpOutput = await codeExecutor.ExecuteCSharpCode(CSharpCode);
            Console.WriteLine(CSharpOutput);
            string pythonOutput= codeExecutor.ExecutePythonCode(pythonCode);
            string JSOutput = codeExecutor.ExecuteJavaScriptCode(JSCode);
            Console.WriteLine(JSOutput);
            Console.WriteLine(pythonOutput);
            // Get answers from compilers and give scores to languages

            // Graphs, stats, etc.






        }

    
        public static async Task<List<QuestionObj>> ReadQuestionsFromJsonAsync(string filePath)
        {
            List<QuestionObj> questionObjs = new List<QuestionObj>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                int id = 1;
                while (!reader.EndOfStream)
                {
                    string line = await reader.ReadLineAsync();
                    var data = JsonSerializer.Deserialize<Dictionary<string, string>>(line);

                    QuestionObj questionObj = new QuestionObj
                    {
                        Id = id,
                        ExampleQuestion = "Q: There were nine computers in the server room. Five more computers were installed each day, from monday to thursday. How many computers are now in the server room?",
                        ExampleAnswer = "A: # solution in Python:\r\n\"\"\"There were nine computers in the server room. Five more computers were installed each day, from monday to thursday. How many computers are now in the server room?\"\"\"\r\ncomputers_initial = 9\r\ncomputers_per_day = 5\r\nnum_days = 4  # 4 days between monday and thursday\r\ncomputers_added = computers_per_day * num_days\r\ncomputers_total = computers_initial + computers_added\r\nresult = computers_total\r\nreturn result",
                        Realuestion = data["question"],
                        RealAnswer = data["answer"]
                    };

                    questionObjs.Add(questionObj);
                    id++;
                }
            }

            return questionObjs;
        }
        
    }
}
