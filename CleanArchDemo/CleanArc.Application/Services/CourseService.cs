using System;
using System.Collections.Generic;
using System.Text;
using CleanArc.Application.ViewModels;
using CleanArc.Domain.Interfaces;

namespace CleanArc.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepostory;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepostory = courseRepository;
        }

        public CoursesViewModel GetCourses()
        {
            return new CoursesViewModel()
            {
                Courses = _courseRepostory.GetCourses()
            };
        }
    }
}
