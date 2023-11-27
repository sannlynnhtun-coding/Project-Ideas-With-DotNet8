using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.Zodiac.Models;

namespace ProjectIdeasWithDotNet8.Zodiac.Services;

public class DataService
{
    public List<ZodiacModel> GetZodiac()
    {
        return JsonConvert.DeserializeObject<List<ZodiacModel>>(Data.JsonData)!;
    }

    public ZodiacModel GetZodiac(int id)
    {
        return GetZodiac().FirstOrDefault(x => x.Id == id)!;
    }
}