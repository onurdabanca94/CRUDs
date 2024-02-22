using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CategoryManager : GenericManager<Category>, ICategoryService
{
    public CategoryManager(IGenericRepository<Category> genericRepository) : base(genericRepository)
    {
        
    }
}
