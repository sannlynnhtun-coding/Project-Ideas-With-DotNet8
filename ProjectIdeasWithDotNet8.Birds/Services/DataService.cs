using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.Birds.Services
{
    public class DataService
    {
        public List<BirdModel> GetBirds()
        {
            return JsonConvert.DeserializeObject<List<BirdModel>>(BirdData.Birds)!;
        }

        public BirdModel GetBird(int id)
        {
            return GetBirds().FirstOrDefault(x => x.Id == id)!;
        }
    }


    public class BirdModel
    {
        public int Id { get; set; }
        public string BirdMyanmarName { get; set; }
        public string BirdEnglishName { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
