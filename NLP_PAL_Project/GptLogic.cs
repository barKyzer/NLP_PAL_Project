using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using NLP_PAL_Project.Models;
using NLP_PAL_Project;

namespace NLP_PAL_Project
{
    public class GptLogic
    {
        public async static Task<GptCompletionResponse> ProcessCompletionRequest(RequestCompletionParam param)
        {
            GptCompletionResponse ret = new GptCompletionResponse();
            dynamic response = await Utils.PostRequest("https://httpbin.org/get", GptUtils.GenerateGptRequestBody(param));
            ret.Id = response["id"];
            ret.Content = response["choices"][0]["message"]["content"];
            ret.FinishReason = response["choices"][0]["finish_reason"];
            ret.OriginalRequest = param;
            return ret;
        }
    }
}
