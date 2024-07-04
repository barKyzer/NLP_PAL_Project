using Newtonsoft.Json;

namespace NLP_PAL_Project
{
    public class Consts
    {
        public static dynamic config;
        public static string BaseUrl;
        public static string MediaType;
        public static string GptUserRole;
        public static string GptAccessKey;

        
        public static void Init()
        {
            config = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(@"../../../config.json"));
            BaseUrl = config["GPT"]["BaseUrl"];
            MediaType = config["GPT"]["MediaType"];
            GptUserRole = config["GPT"]["Roles"]["User"];
            GptAccessKey = config["GPT"]["AccessKey"];
        }
    }
}
