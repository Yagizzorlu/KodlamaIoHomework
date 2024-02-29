using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryInstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InMemoryInstructorDal()
        {
            _instructors = new List<Instructor>
            {
                new Instructor{ Id = 1, FirstName = "Engin ", LastName = "Demiroğ" },
                new Instructor{ Id = 2, FirstName = "Yağız ", LastName = "Zorlu" },
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.SingleOrDefault(i=> i.Id == instructor.Id);
            _instructors.Remove(instructorToDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public List<Instructor> GetById(int Id)
        {
            return _instructors.Where(i => i.Id == Id).ToList();
        }

        public void Update(Instructor instructor)
        {
            Instructor instructorToDelete = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            instructorToDelete.Id = instructor.Id;
            instructorToDelete.FirstName = instructor.FirstName;
            instructorToDelete.LastName = instructor.LastName;
        }
    }
}
