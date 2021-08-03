using System.Collections.Generic;

using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infrastructure.Data.Context;

namespace CleanArch.Infrastructure.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _ctx;

        public CourseRepository(UniversityDbContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IEnumerable<Course>? GetCourses()
        {
            return _ctx.Courses;
        }
    }
}
