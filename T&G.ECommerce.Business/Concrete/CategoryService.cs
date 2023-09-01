using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_G.ECommerce.Business.Abstract;
using T_G.ECommerce.DataAccess.Abstract;
using T_G.ECommerce.Entities.Concrete;

namespace T_G.ECommerce.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        //I called categoryDal instance from IoC with constructor injection 
        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        //All Categories listed
        public IList<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
