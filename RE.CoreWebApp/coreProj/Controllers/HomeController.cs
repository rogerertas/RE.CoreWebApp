﻿using MyCoreApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using MyCoreApp.Services;
using MyCoreApp.Entities;

namespace MyCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private IResturauntData _restaurantData;
        private IGreeter _greeter;

        public HomeController(
            IResturauntData restaurantData,
            IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }
        public ViewResult Index()
        {
            var model = new HomePageViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurentGreeting = _greeter.GetGreeting();

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(RestaurantEditViewModel model)
        {
            if (ModelState.IsValid) { 
            var restaurant = new Restaurant();
            restaurant.Name = model.Name;
            restaurant.Cuisine = model.Cuisine;

            _restaurantData.Add(restaurant);

            return RedirectToAction("Details", new { id = restaurant.Id });
            }
            return View();
        }
        public IActionResult Details(int id)
        {
            var model = _restaurantData.Get(id);
            if (model == null)
            {
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
