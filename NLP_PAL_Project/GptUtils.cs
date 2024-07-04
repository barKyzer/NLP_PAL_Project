using NLP_PAL_Project.Models;
using System.Data;
using System.Text;

namespace NLP_PAL_Project
{
    public class GptUtils
    {
        public static StringContent GenerateGptRequestBody(QuestionObj param)
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

        public static List<GptRequestMessageObject> CreateMessageList(QuestionObj questionObj)
        {
            List<GptRequestMessageObject> messages;
            messages = new List<GptRequestMessageObject> {
               new GptRequestMessageObject {
                   role = Consts.GptUserRole,
                   content = questionObj.Intro
               },
               new GptRequestMessageObject {
                   role = Consts.GptUserRole,
                   content = questionObj.ExampleQuestion
               },
               new GptRequestMessageObject {
                   role = Consts.GptUserRole,
                   content = questionObj.ExampleAnswer
               },
               new GptRequestMessageObject {
                   role = Consts.GptUserRole,
                   content = questionObj.RealQuestion
               }
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
