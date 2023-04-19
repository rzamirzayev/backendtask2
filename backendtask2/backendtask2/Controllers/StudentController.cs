using backendtask2.Models;
using backendtask2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace backendtask2.Controllers
{
    public class StudentController : Controller
    {

        public ViewResult Index()
        {
            List<Student> Students = new List<Student>()
            {
                new Student{Id = 1, Name = "Rza", Point = 100},
                new Student{Id = 2, FullName = "Sabir", Point = 90},
                new Student{Id = 3, FullName = "Sahin", Point = 80}
            };

            List<Group> Groups = new List<Group>()
            {
                new Group{Id = 1, Number = "P328"},
                new Group{Id = 2, Number = "P327"},
                new Group{Id = 3, Number = "P326"}
            };

            StudentViewModel AllInformation = new StudentViewModel
            {
                Students = Students,
                Groups = Groups,
            };

            return View(AllInformation);
        }

        public ViewResult Detail(int searchid)
        {
            List<Student> Students = new List<Student>()
            {
                new Student{Id = 1, Name = "Rza", Point = 100},
                new Student{Id = 2, FullName = "Sabir", Point = 90},
                new Student{Id = 3, FullName = "Sahin", Point = 80}
            };


            Student studentFiltered = Students.Find(x => x.Id == searchid);
            return View(studentFiltered);
        }
    }
}