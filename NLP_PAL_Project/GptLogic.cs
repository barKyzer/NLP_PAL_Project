using NLP_PAL_Project.Models;

namespace NLP_PAL_Project
{
    public class GptLogic
    {
        public async static Task<GptCompletionResponse> ProcessCompletionRequest(QuestionObj questionObj)
        {
            GptCompletionResponse ret = new GptCompletionResponse();
            dynamic response = await Utils.PostRequest(Consts.BaseUrl, GptUtils.GenerateGptRequestBody(questionObj));
            ret.Id = response["id"];
            ret.Content = response["choices"][0]["message"]["content"];
            ret.FinishReason = response["choices"][0]["finish_reason"];
            ret.OriginalRequest = questionObj;
            return ret;
        }

        public async static Task<dynamic> GeneratePalAnswers(List<QuestionObj> questionObjs)
        {
            List<Task<GptCompletionResponse>> taskList = new List<Task<GptCompletionResponse>>();
            // Send prompt to GPT and get code - Dan
            foreach (QuestionObj obj in questionObjs)
            {
                Task<GptCompletionResponse> task = ProcessCompletionRequest(obj);
                taskList.Add(task);
            }
            dynamic[] results = await Task.WhenAll(taskList.ToArray());
            return results;
        }
    }
}
