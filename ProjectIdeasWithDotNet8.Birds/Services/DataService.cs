using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.Birds.Models;
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
            return JsonConvert.DeserializeObject<List<BirdModel>>(Data.JsonData)!;
        }

        public BirdModel GetBird(int id)
        {
            return GetBirds().FirstOrDefault(x => x.Id == id)!;
        }
    }
}
