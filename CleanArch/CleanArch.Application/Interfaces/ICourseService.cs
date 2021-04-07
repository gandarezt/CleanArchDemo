using CleanArch.Application.ViewModels;
using System.Linq;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        IQueryable<CourseViewModel> GetCourses();

        void Create(CourseViewModel courseViewModel);
    }
}
