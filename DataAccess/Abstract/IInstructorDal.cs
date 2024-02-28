using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IInstructorDal 
    {
        public void Add(Instructor instructor);
        public void Delete(Instructor instructor);
        public List<Instructor> GetAll();
        public List<Instructor> GetById(int Id);
        public void Update(Instructor instructor);
    }
}
