using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public ListModel(IRestaurantData restaurantData)
        {
            RestaurantData = restaurantData;
        }

        public IRestaurantData RestaurantData { get; }

        public IEnumerable<Restaurant> Restaurants { get; set; }
        public void OnGet()
        {
            Restaurants = RestaurantData.GetAll();
        }
    }
}
