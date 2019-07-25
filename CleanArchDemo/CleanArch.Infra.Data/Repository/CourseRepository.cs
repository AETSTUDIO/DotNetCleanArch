using CleanArc.Domain.Interfaces;
using CleanArc.Domain.Models;
using CleanArc.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArc.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<Course> GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
