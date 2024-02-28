using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        public List<Instructor> GetAll();
        public void Add(Instructor instructor);
        public void Delete(Instructor instructor);
        public void Update(Instructor instructor);
    }
}
