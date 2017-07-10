using System.ComponentModel.DataAnnotations;

namespace MyCoreApp.Entities
{
    public enum CuisineType
    {
        None,
        Italian,
        French,
        American
    }
    public class Restaurant
    {
        public CuisineType Cuisine { get; set; }
        public int Id { get; set; }

        [Required, MaxLength(100)]        
        [Display(Name ="Restaurant Name")] //Det vi vill att användaren ska se
        public string Name { get; set; }
    }
}
