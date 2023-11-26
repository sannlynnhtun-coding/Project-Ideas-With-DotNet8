using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.DreamDictionary.Models;
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
}
