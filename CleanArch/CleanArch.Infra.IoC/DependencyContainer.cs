using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Interfaces;
using CleanArch.Info.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    class DependencyContainer
    {
        public static void RegisterService(IServiceCollection services)
        {
            services.AddScoped<ICourseService, CourseService>();


            services.AddScoped<ICourseRepository, CourseRepository>();
        }
    }
}
