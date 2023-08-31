using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_G.ECommerce.Core.Request
{
    public class Filter
    {
        public Guid? CategoryId { get; set; } = null;
        public int? MinPrice { get; set; }
        public int? MaxPrice { get; set; }
        public decimal? Rating { get; set; }
        public string? OrderBy { get; set; }
    }
}
