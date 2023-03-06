using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;
using System.Collections.Generic;

namespace Tamagotchi.Controllers
{
    public class PetsController : Controller
    {

      [HttpGet("/pets/new")]
      public ActionResult New()
      {
        return View();
      }

      [HttpGet("/pets/{id}")]
      public ActionResult Play(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        return View(foundPet);
      }

      [HttpGet("/pets/index")]
      public ActionResult Index()
      {
        List<PocketPet> allPets = PocketPet.GetAll();
        return View(allPets);
      }
      [HttpPost("/pets/play")]
      public ActionResult Play(string name)
      {
        PocketPet newPet = new PocketPet(1, name);
        return View(newPet);
      }

      [HttpPost("/pets/delete")]
      public ActionResult DeleteAll()
      {
        PocketPet.ClearAll();
        return View();
      }
      [HttpPost("/pets/feed")]
      public ActionResult Feed(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        foundPet.Feed();
        return View(foundPet);
      }
      [HttpPost("/pets/joy")]
      public ActionResult Joy(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        foundPet.Rumpus();
        return View(foundPet);
      }
      [HttpPost("/pets/slumber")]
      public ActionResult Slumber(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        foundPet.Sleep();
        return View(foundPet);
      }
      [HttpPost("/pets/foodfight")]
      public ActionResult FoodFight(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        foundPet.FoodFight();
        return View(foundPet);
      }
      [HttpPost("/pets/time")]
      public ActionResult Time(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        foundPet.Time();
        return View(foundPet);
      }
      [HttpPost("/pets/dead")]
      public ActionResult Dead(int id)
      {
        PocketPet foundPet = PocketPet.Find(id);
        PocketPet.Delete(id);
        return View(foundPet);
      }
    }
}