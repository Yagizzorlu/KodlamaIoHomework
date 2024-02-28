using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICourseDal 
    {
        public void Add(Course course);
        public void Delete(Course course);
        public List<Course> GetAll();
        public List<Course> GetById(int Id);
        public void Update(Course course);
    }
}
