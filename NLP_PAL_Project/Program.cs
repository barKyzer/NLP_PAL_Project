namespace NLP_PAL_Project
{  
    class Program
    {
       
        public static async Task Main(string[] args)
        {
            Consts.Init();
            var ret = await GptLogic.ProcessCompletionRequest(new Models.RequestCompletionParam());
            Console.WriteLine(ret);
        }
    }
}