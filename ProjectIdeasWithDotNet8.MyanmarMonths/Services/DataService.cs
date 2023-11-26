using Newtonsoft.Json;
using ProjectIdeasWithDotNet8.MyanmarMonths.Models;

namespace ProjectIdeasWithDotNet8.MyanmarMonths.Services;

public class DataService
{
    public List<MyanmarMonthModel> GetMonths()
    {
        var lst = JsonConvert.DeserializeObject<List<MyanmarMonthModel>>(Data.Months)!;
        lst.ForEach(x =>
        {
            x.ImgUrl = $"myanmar-months/img/{x.Id}.jpg";
        });
        return lst;
    }

    public MyanmarMonthModel GetMonth(int id)
    {
        return GetMonths().FirstOrDefault(x => x.Id == id)!;
    }
}
