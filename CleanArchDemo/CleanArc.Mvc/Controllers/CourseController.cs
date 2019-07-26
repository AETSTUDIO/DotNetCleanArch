using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArc.Application.Interfaces;
using CleanArc.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArc.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService _courseServie;

        public CourseController(ICourseService courseService)
        {
            _courseServie = courseService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CoursesViewModel model = _courseServie.GetCourses();
            return View(model);
        }
    }
}
