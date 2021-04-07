using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Models;

namespace CleanArch.Application.AutoMapper
{
    public class DomainToViewModalProfile : Profile
    {
        public DomainToViewModalProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
