using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TaskThree.BLL.Interfaces;
using TaskThree.BLL.Services;
using TaskThree.DAL.Entities;
using TaskThree.DAL.Interfaces;
using TaskThree.DAL.Repositories;

namespace TaskThree.BLL.Extensions
{
    public static class ServicesExtensions
    {
        public static void AddAutoMapper(this IServiceCollection services)
        {
            var cfg = new MapperConfiguration(mc =>
            {
                mc.AddMaps(Assembly.GetAssembly(typeof(ServicesExtensions)));
            });
            IMapper mapper = new Mapper(cfg);
            services.AddSingleton(mapper);
        }

        public static void ConfigureDAL(this IServiceCollection services)
        {
            services.AddScoped<IRestaurantService, RestaurantService>();
            services.AddScoped<IRepository<Restaurant>, MyRestaurantsRepository>();
        }
    }
}
