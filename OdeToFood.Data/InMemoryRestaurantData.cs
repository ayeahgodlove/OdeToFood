using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Ayeah's Pizza", Location = "MaryLand", Cuisine = CuisineType.African },
                new Restaurant { Id = 2, Name = "Mboat's Foods", Location = "Paris", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 3, Name = "Contry Chop", Location = "Bamenda", Cuisine = CuisineType.African },
                new Restaurant { Id = 4, Name = "Western Dishes", Location = "Yaounde", Cuisine = CuisineType.Mexican },
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name); //or
            //return from r in restaurants
            //       orderby r.Name
            //       select r;
        }
    }
}
