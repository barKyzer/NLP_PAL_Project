using NLP_PAL_Project.Models;

namespace NLP_PAL_Project
{
    public class GptLogic
    {
        public async static Task<GptCompletionResponse> ProcessCompletionRequest(RequestCompletionParam param)
        {
            GptCompletionResponse ret = new GptCompletionResponse();
            dynamic response = await Utils.PostRequest(Consts.BaseUrl, GptUtils.GenerateGptRequestBody(param));
            ret.Id = response["id"];
            ret.Content = response["choices"][0]["message"]["content"];
            ret.FinishReason = response["choices"][0]["finish_reason"];
            ret.OriginalRequest = param;
            return ret;
        }
    }
}
