using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.Core.Dtos;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.Entities.Dtos
{
    public class ProductDto : Dto
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }

    }
}
