using CleanArc.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Application.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
