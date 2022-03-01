using LexiconMVC_ViewModels.Models;
using LexiconMVC_ViewModels.Models.Data;
using LexiconMVC_ViewModels.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC_ViewModels.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CityController : Controller
    {
        private ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Cities.ToList());
        }

        

        // GET: CityController/Create
        [HttpGet]
        public ActionResult Create()
        {
            CreateCityViewModel model = new CreateCityViewModel();
           
            return View(model);
        }

        // POST: CityController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCityViewModel createCity)
        {
            if (ModelState.IsValid)
            {
                City city = new City()
                {
                    CityName = createCity.CityName
                };
                _context.Cities.Add(city);
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index), "City");
        }

        // GET: CityController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            City city = _context.Cities.FirstOrDefault(x => x.CityId == id);

            if (city == null)
            {
                return RedirectToAction("Index");
            }

            CreateCityViewModel editCity = new CreateCityViewModel()
            {
                CityName = city.CityName
            };

            return View(editCity);
        }

        // POST: CountryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, CreateCityViewModel cityToEdit)
        {
            City city = _context.Cities.FirstOrDefault(x => x.CityId == id);
            if (ModelState.IsValid)
            {
                city.CityName = cityToEdit.CityName;

                _context.Entry(city).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            return View(cityToEdit);
        }

        public ActionResult Delete(int id)
        {
            var cityToDelete = _context.Cities.FirstOrDefault(x => x.CityId == id);
            _context.Cities.Remove(cityToDelete);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index), "City");
        }
    }
}
