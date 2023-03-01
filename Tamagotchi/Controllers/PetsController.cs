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
        PocketPet newPet = new PocketPet(name);
        return View(newPet);
      }

      [HttpPost("/pets/delete")]
      public ActionResult DeleteAll()
      {
        PocketPet.ClearAll();
        return View();
      }
    }
}