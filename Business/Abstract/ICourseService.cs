using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICourseService
    {
        public List<Course> GetAll();
        public void Add(Course course);
        public void Delete(Course course);
        public void Update(Course course);
    }
}
