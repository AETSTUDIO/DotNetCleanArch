using CleanArc.Application.Interfaces;
using CleanArc.Application.Services;
using CleanArc.Domain.Interfaces;
using CleanArc.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
