using NLP_PAL_Project.Models;
using System.Text;

namespace NLP_PAL_Project
{
    public class GptUtils
    {
        public static StringContent GenerateGptRequestBody(RequestCompletionParam param)
        {
            StringContent stringContent = new(
                System.Text.Json.JsonSerializer.Serialize(new
                {
                    model = "gpt-3.5-turbo",
                    messages = CreateMessageList(param)
                }),
                Encoding.UTF8,
                "application/json"
            );
            return stringContent;
        }

        public static List<GptRequestMessageObject> CreateMessageList(RequestCompletionParam param)
        {
            List<GptRequestMessageObject> messages;
            messages = new List<GptRequestMessageObject> {
                        GptPromptGenerator(Consts.GptUserRole, Consts.GptExampleQuestionMessage, new string[] {
                            "1",
                            "2"
                        })
                    };
            return messages;
        }
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

    }
}
