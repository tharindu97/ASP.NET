using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var course = new List<Course>();
            for (int i = 1; i < 11; i++)
            {
                course.Add(new Course()
                {
                    Id= i,
                    Title = $"Course name {i}",
                    Price = "2000",
                    //18 52
                    
                });
            }
            return View(course);
        }
    }
}
