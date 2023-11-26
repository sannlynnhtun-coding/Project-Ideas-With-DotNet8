using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.DreamDictionary.Services
{
    public class DataService
    {
        public BlogResponseModel Get()
        {
            return JsonConvert.DeserializeObject<BlogResponseModel>(Data.JsonData);
        }

        public List<BlogHeaderModel> GetHeaders()
        {
            return Get().BlogHeader.ToList();
        }

        public List<BlogDetailModel> GetDetail()
        {
            return Get().BlogDetail.ToList();
        }
    }

    public class BlogResponseModel
    {
        public BlogHeaderModel[] BlogHeader { get; set; }
        public BlogDetailModel[] BlogDetail { get; set; }
    }

    public class BlogHeaderModel
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
    }

    public class BlogDetailModel
    {
        public int BlogDetailId { get; set; }
        public int BlogId { get; set; }
        public string BlogContent { get; set; }
    }
}
