using System;

namespace NLP_PAL_Project
{  
    class Program
    {
       
        public static async Task Main(string[] args)
        {
            Consts.Init();
            var ret = await GptLogic.ProcessCompletionRequest(new Models.RequestCompletionParam());
            Console.WriteLine(ret);

            /*
             * CodeExecutor codeExecutor= new CodeExecutor();
            string pythonCode = "print(\"test\") \nprint(\"test\")";
            string JSCode = "console.log('this is java script');";
            string CSharpCode = @"
        using System;

        public class Program
        {
            public static string Main()
            {
                return ""Hello, World!"";
            }
        }

        Program.Main();
    ";
            string output = await codeExecutor.ExecuteCSharpCode(CSharpCode);
            Console.WriteLine(output);
            codeExecutor.ExecutePythonCode(pythonCode);
            codeExecutor.ExecuteJavaScriptCode(JSCode);
            */
            
           


        }
    }
}