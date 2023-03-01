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

      [HttpPost("/pets")]
      public ActionResult Pets(string name)
      {
        PocketPet newPet = new PocketPet(name);
        return View(newPet);
      }

      [HttpGet("/pets/index")]
      public ActionResult Index()
      {
        List<PocketPet> allPets = PocketPet.GetAll();
        return View(allPets);
      }

      
    }
}