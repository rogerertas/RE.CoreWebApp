using MyCoreApp.Entities;
using System.ComponentModel.DataAnnotations;

namespace MyCoreApp.ViewModels
{
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
