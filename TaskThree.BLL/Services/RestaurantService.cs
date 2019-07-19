using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using TaskThree.BLL.DTO;
using TaskThree.BLL.Interfaces;
using TaskThree.DAL.Entities;
using TaskThree.DAL.Interfaces;

namespace TaskThree.BLL.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRepository<Restaurant> _repository;
        private readonly IMapper _mapper;

        public RestaurantService(IRepository<Restaurant> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public IEnumerable<RestaurantDTO> GetAllRestaurant()
        {
            return _repository
                .Get()
                .Select(i => _mapper.Map<Restaurant, RestaurantDTO>(i));
        }

        public IEnumerable<RestaurantDTO> GetByPostalCode(string code)
        {
            return _repository
                .Get(i => i.Address.Contains(code))
                .Select(i => _mapper.Map<Restaurant, RestaurantDTO>(i));
        }
    }
}
