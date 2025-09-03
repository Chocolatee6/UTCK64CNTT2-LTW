using Microsoft.AspNetCore.Mvc;
using System.Net.Cache;
using TvcDay03.Models;
namespace TvcDay03.Controllers
{
    public class MyNewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "Test";
            ViewData["time"] = DateTime.Now;


            var student = new Student();
            student.Id = 1;
            student.Name = "John";
            student.Age = 20;
            student.IsActive = true;
            ViewBag.Student = student;
            
            // Tạo danh sách student
            //List<Student> students = new List<Student>
            //{
            //    new Student { Id = 1, Name = "Test", Age = 20, IsActive = true },
            //    new Student { Id = 2, Name = "John", Age = 22, IsActive = false }
            //};
            //ViewData["students"] = students;
            return View();

        }
        public IActionResult getStudent(int id, string name, int age,bool isasctive)
        {
            var student = new Student();
            student.Id = id;
            student.Name = name;
            student.Age = age;
            student.IsActive = isasctive;
            return View(student);
        }

        public IActionResult postStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult postStudent(int id, string name, int age, bool isasctive) 
        {
            var student = new Student();
            student.Id = id;
            student.Name = name;
            student.Age = age;
            student.IsActive = isasctive;
            return View("getStudent", student);
        }
    }
}
