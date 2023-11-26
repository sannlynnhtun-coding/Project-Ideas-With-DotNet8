using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.MyanmarProverbs.Models;

public class MyanmarProverbDetailModel
{
    public int TitleId { get; set; }
    public int ProverbId { get; set; }
    public string ProverbName { get; set; } = null!;
    public string ProverbDesp { get; set; } = null!;
}
