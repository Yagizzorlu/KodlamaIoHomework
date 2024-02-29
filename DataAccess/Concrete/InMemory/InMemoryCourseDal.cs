using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        List<Course> _courses;
        public InMemoryCourseDal()
        {
            _courses = new List<Course>
            {
                new Course{ Id = 1, Description = "SQL Kursu", CategoryId = 1, UnitPrice = 75 },
                new Course{ Id = 2, Description = "C# 2021 Kursu", CategoryId = 2, UnitPrice = 25 },
                new Course{ Id = 3, Description = "C# 2024 Kursu", CategoryId = 2, UnitPrice = 34 },
                new Course{ Id = 4, Description = "JAVA Kursu", CategoryId = 3, UnitPrice = 45 },
                new Course{ Id = 5, Description = "JAVASCRIPT Kursu", CategoryId = 4, UnitPrice = 50 }
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c=>c.Id == course.Id);
            _courses.Remove(courseToDelete);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public List<Course> GetById(int Id)
        {
            return _courses.Where(c => c.Id == Id).ToList();
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c=>c.Id ==course.Id);
            courseToUpdate.Id = course.Id;
            courseToUpdate.Description = course.Description;
            courseToUpdate.UnitPrice = course.UnitPrice;
            courseToUpdate.CategoryId = course.CategoryId;
        }
    }
}
