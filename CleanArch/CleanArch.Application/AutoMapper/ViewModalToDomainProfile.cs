using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;

namespace CleanArch.Application.AutoMapper
{
    public class ViewModalToDomainProfile : Profile
    {
        public ViewModalToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
