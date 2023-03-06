// using Microsoft.AspNetCore.Mvc;
// using Tamagotchi.Models;
// using System.Collections.Generic;

// namespace Tamagotchi.Controllers
// {
//   public class ParentsController : Controller
//   {
//     [HttpPost("owner/{ownerId}/pocketPets")]
//     public ActionResult Create(int parentId, string pocketPetName)
//     {
//       Dictionary <string, object> model = new Dictionary<string, object>();

//       Parent foundParent = Parent.Find(parentId);
//       PocketPet newPocketPet = new PocketPet(pocketPetName);
//       newPocketPet.Save();
//       foundParent.AddPocketPet(newPocketPet);
//       List<PocketPet> parentPocketPets = foundParent.PocketPets;
//       model.Add("pocketPet", parentPocketPets);
//       model.Add("parent", foundParent);
//       return View("Show", model);
//     }
//   }
// }

edits made on branch 0306 still pushing to main branch despite not pushing directly to it