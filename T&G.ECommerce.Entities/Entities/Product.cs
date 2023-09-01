using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.Core.Entities;

namespace T_G.ECommerce.Entities.Concrete
{
    public class Product : Entity
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        [Range(typeof(Decimal), "0", "5", ErrorMessage = "{0} must be a decimal/number between {1} and {2}.")]
        public decimal Rating { get; set; }

        public Category Category { get; set; }
    }
}
