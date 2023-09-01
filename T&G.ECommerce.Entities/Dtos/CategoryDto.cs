using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.Core.Dtos;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.Entities.Dtos
{
    public class CategoryDto : Dto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
