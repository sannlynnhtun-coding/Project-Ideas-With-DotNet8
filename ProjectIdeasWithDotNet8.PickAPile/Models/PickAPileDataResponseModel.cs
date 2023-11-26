namespace ProjectIdeasWithDotNet8.PickAPile.Models
{
    public class PickAPileDataResponseModel
    {
        public PickAPileQuestionModel[] Questions { get; set; }
        public PickAPileAnswerModel[] Answers { get; set; }
    }

    public class PickAPileResponseModel
    {
        public int PageNo { get; set; }
        public int PageSize { get; set; }   
        public int PageCount { get; set; }
        public bool IsEndPage { get; set; }
        public List<PickAPileQuestionModel> Questions { get; set; }
    }
}
