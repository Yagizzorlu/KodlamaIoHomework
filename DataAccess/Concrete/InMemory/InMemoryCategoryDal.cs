using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public InMemoryCategoryDal()
        {
            _categories = new List<Category>
            {
                new Category{Id = 1, CategoryName = "Backend Kursu"},
                new Category{Id = 2, CategoryName = "Frontend Kursu"},
                new Category{Id = 3, CategoryName = "Fullstack Kursu"}
            };
        }

        public void Add(Category category)
        {
            _categories.Add(category);
        }

        public void Delete(Category category)
        {
            Category categoryToDelete = _categories.SingleOrDefault(c => c.Id == category.Id);
            _categories.Remove(categoryToDelete);
        }

        public List<Category> GetAll()
        {
            return _categories;
        }

        public List<Category> GetById(int Id)
        {
            return _categories.Where(c => c.Id == Id).ToList();
        }

        public void Update(Category category)
        {
            Category categoryToUpdate = _categories.SingleOrDefault(c => c.Id == category.Id);
            categoryToUpdate.Id = category.Id;
            categoryToUpdate.CategoryName = category.CategoryName;
        }
    }
}

