using NLP_PAL_Project.Models;
using System.Text;

namespace NLP_PAL_Project
{
    public class GptUtils
    {
        public static GptRequestMessageObject GptPromptGenerator(string role, string template, string[]? parameters)
        {
            string content;
            if (parameters == null || parameters.Length <= 0)
            {
                content = template;
            }
            else
            {
                content = string.Format(template, parameters);
            }
            return new GptRequestMessageObject
            {
                role = role,
                content = content
            };
        }

        public static StringContent GenerateGptRequestBody(RequestCompletionParam param, string articlePart = "")
        {
            StringContent stringContent = new(
                System.Text.Json.JsonSerializer.Serialize(new
                {
                    model = "gpt-4",
                    messages = new List<GptRequestMessageObject>()
                }),
                Encoding.UTF8,
                "application/json"
            );
            return stringContent;
        }
    }
}
