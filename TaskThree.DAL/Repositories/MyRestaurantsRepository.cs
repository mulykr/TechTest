using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TaskThree.DAL.Entities;
using TaskThree.DAL.Interfaces;

namespace TaskThree.DAL.Repositories
{
    public class MyRestaurantsRepository : IRepository<Restaurant>
    {
        private readonly List<Restaurant> _restaurants;

        public MyRestaurantsRepository()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant
                {
                    Name = "Celentano",
                    Address = "1234"
                },
                new Restaurant
                {
                    Name = "McDonald's",
                    Address = "4321"
                }
            };
        }

        public IEnumerable<Restaurant> Get()
        {
            return _restaurants.AsEnumerable();
        }

        public IEnumerable<Restaurant> Get(Expression<Func<Restaurant, bool>> filter)
        {
            return _restaurants
                .AsQueryable()
                .Where(filter);
        }

        public Restaurant Get(string id)
        {
            return _restaurants
                .FirstOrDefault(i => i.Name == id);
        }

        public void Create(Restaurant item)
        {
            if (item != null)
            {
                _restaurants.Add(item);
            }
        }

        public void Update(Restaurant item)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }
    }
}
