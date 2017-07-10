using MyCoreApp.Entities;
using System.Collections.Generic;

namespace MyCoreApp.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string CurentGreeting { get; set; }
    }
}
