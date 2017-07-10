using MyCoreApp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MyCoreApp.Services
{
    public interface IResturauntData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        void Add(Restaurant newRestaurant);
    }

    public class InMemoryRestaurantData : IResturauntData
    {
        static InMemoryRestaurantData()
        {
            _Restaurants = new List<Restaurant>
            {
                new Restaurant{Id = 1, Name ="Food Court kista" },
                new Restaurant{Id = 2, Name= "Chilli" },
                new Restaurant{Id = 3, Name="Lunch Vagnen"}
            };
        }

        public void Add(Restaurant newRestaurant)
        {
            newRestaurant.Id = _Restaurants.Max(r => r.Id) + 1;
            _Restaurants.Add(newRestaurant);
        }

        public Restaurant Get(int id)
        {
            return _Restaurants.FirstOrDefault(r => r.Id == id);
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _Restaurants;
        }

        static List<Restaurant> _Restaurants;
    }

}
