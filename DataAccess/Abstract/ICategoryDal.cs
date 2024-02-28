using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDal 
    {
        public void Add(Category category);
        public void Delete(Category category);
        public List<Category> GetAll();
        public List<Category> GetById(int Id);
        public void Update(Category category);
    }
}
