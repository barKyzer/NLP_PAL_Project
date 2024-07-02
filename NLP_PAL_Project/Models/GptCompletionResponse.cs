using System;

namespace NLP_PAL_Project.Models
{
    public class GptCompletionResponse
    {
        public string Id { get; set; }
        public string Content { get; set; }
        public string FinishReason { get; set; }
        public RequestCompletionParam OriginalRequest { get; set; }
        public int TotalTokens { get; set; }
    }
}
