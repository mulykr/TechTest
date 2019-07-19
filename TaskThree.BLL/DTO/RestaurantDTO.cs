using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using TaskThree.DAL.Entities;

namespace TaskThree.BLL.DTO
{
    public class RestaurantDTO
    {
        public string Name { get; set; }
        public string TypeOfFood { get; set; }
        public string ContactInfo { get; set; }
        public string Address { get; set; }
    }

    public class RestaurantProfile : Profile
    {
        public RestaurantProfile()
        {
            CreateMap<RestaurantDTO, Restaurant>();
            CreateMap<Restaurant, RestaurantDTO>();
        }
    }
}
