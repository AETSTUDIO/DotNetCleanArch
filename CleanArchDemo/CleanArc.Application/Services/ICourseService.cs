using CleanArc.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Application.Services
{
    public interface ICourseService
    {
        CoursesViewModel GetCourses();
    }
}
