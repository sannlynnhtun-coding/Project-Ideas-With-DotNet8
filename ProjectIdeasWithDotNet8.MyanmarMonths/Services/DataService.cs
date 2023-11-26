using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.MyanmarMonths.Models;

namespace ProjectIdeasWithDotNet8.MyanmarMonths.Services;

public class DataService
{
    public List<MyanmarMonthModel> GetMonths()
    {
        return JsonConvert.DeserializeObject<List<MyanmarMonthModel>>(Data.Months)!;
    }

    public MyanmarMonthModel GetMonth(int id)
    {
        return GetMonths().FirstOrDefault(x => x.Id == id)!;
    }
}
