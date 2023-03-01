using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

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

    }
}