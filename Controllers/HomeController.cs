using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext ctx = new ApplicationDbContext();

        public IActionResult Index(int id)
        {
            var pet = ctx.Pets.Where(p => p.Id == id).FirstOrDefault();
            return View(pet);
        }

        public IActionResult Pets()
        {
            var pets = ctx.Pets.ToList();
            return View(pets);
        }

        public ActionResult<Pet> Pet(int id)
        {
            return ctx.Pets.Where(p => p.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public ActionResult<Pet> Pet(Pet pet)
        {
            var result = ctx.Pets.Where(p => p.Id == pet.Id).FirstOrDefault();
            Console.WriteLine(pet);

            result.Happy = pet.Happy;
            result.Hunger = pet.Hunger;
            result.Health = pet.Health;
            result.State = pet.State;
            result.Sleeping = pet.Sleeping;
            ctx.SaveChanges();

            return result;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Pet pet)
        {
            ctx.Pets.Add(pet);
            ctx.SaveChanges();
            return RedirectToAction("Pets");
        }
    }
}
