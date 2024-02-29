using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
            foreach (var course in courseManager.GetAll()) 
            {
                Console.WriteLine(course.Description);
            }

            InstructorManager instructorManager = new InstructorManager(new InMemoryInstructorDal());
            foreach (var instructor in instructorManager.GetAll())
            {
                Console.WriteLine("Eğitmenin Adı ve Soyadı :", instructor.FirstName + instructor.LastName);
            }

            CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
