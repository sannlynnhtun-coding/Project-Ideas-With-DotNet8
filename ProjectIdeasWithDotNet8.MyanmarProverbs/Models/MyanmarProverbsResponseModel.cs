using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectIdeasWithDotNet8.MyanmarProverbs.Models
{
    public class MyanmarProverbsResponseModel
    {
        public List<MyanmarProverbsTitleModel> MMProverbsTitle { get; set; }
        public List<MyanmarProverbDetailModel> MMProverbDetail { get; set; }
    }
}
