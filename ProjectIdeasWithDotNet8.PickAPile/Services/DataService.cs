using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.PickAPile.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.PickAPile.Services
{
    public class DataService
    {
        public PickAPileResponseModel GetQuestions(int pageNo, int pageSize)
        {
            var lst = Get().Questions.Skip((pageNo - 1) * pageSize).Take(pageSize).ToList();
            int totalPageCount = Get().Questions.Length;
            int pageCount = totalPageCount / pageSize;
            if (totalPageCount % pageSize > 0) pageCount++;
            return new PickAPileResponseModel
            {
                PageNo = pageNo,
                PageSize = pageSize,
                Questions = lst,
                PageCount = pageCount,
                IsEndPage = pageCount == pageNo
            };
        }

        public List<PickAPileAnswerModel> GetAnswer(int questionId)
        {
            return Get().Answers.Where(x=> x.QuestionId == questionId).ToList();
        }

        private PickAPileDataResponseModel Get()
        {
            return JsonConvert.DeserializeObject<PickAPileDataResponseModel>(Data.JsonData);
        }
    }
}
