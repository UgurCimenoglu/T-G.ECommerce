using T_G.ECommerce.Core.Entities;


namespace T_G.ECommerce.Entities.Concrete
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
