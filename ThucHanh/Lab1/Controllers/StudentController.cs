using Lab1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab1.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> listudent = new List<Student>();
        public StudentController() {
            listudent = new List<Student>()
            {
                new Student()
                {
                    Id = 101, Name = "Hoàng Quốc Anh", Branch = Branch.IT, Gender = Gender.Male, IsRegular = true,Address = "Nam Định",Email = "hqanh7605@gmail.com"
                }



            };
            
        }


        public IActionResult Index()
        {
            return View(listudent);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            { new SelectListItem { Text = "IT", Value  = "1"},
            new SelectListItem { Text = "BE", Value  = "2"},
            new SelectListItem { Text = "CE", Value  = "3"},
            new SelectListItem { Text = "EE", Value  = "4"},



            };
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            if(ModelState.IsValid)
            {
                student.Id = listudent.Last<Student>().Id + 1;
                listudent.Add(student);
                return View("Index", listudent);
            }
            ViewBag.AllGenders = Enum.GetValues(typeof(Gender)).Cast<Gender>().ToList();
            ViewBag.AllBranches = new List<SelectListItem>()
            { new SelectListItem { Text = "IT", Value  = "1"},
            new SelectListItem { Text = "BE", Value  = "2"},
            new SelectListItem { Text = "CE", Value  = "3"},
            new SelectListItem { Text = "EE", Value  = "4"},
            };
                        return View(student);
        }
    }
}
