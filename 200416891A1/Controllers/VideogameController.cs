using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _200416891A1.Models;

namespace _200416891A1.Controllers
{
    public class VideogameController : Controller
    {
        List<Videogame> videogamesList = new List<Videogame>()
    {
            //Insert Videogames
            new Videogame() {Name ="Fornite", Description = "Battle Royale", ID = 1,Genres = new Genre{Name = "Action", Description = "" },
                Reviews = new Review{Name = "Carlos", Stars = 5, Subject = "Free 2 Play", ReviewDescription = "Can't believe this awesome game is free!"}
                , Price = 0.00, Developers = new Developer{ Name = "Epic Games", Website ="epicgames.com" }, MinimumRequirements ="Xbox," +
                "PS4, Nintendo Switch, iOS, Android, Pc",
                Publishers = new Publisher{ Name = "Epic Games", Website = "epicgames.com" } },

            new Videogame() {Name ="Fifa 19", Description = "Soccer Simulation", ID = 2,Genres = new Genre{Name = "Sports", Description = "Simulation for soccer with multiple game modes" },
                Reviews = new Review{Name = "Steve", Stars = 2, Subject = "Same thing as last year", ReviewDescription = "This is the exact same things from last year. Do Something!!"}
                , Price = 0.00, Developers = new Developer{ Name = "EA Vancouver Studios", Website ="ea.com" }, MinimumRequirements ="Xbox, " +
                "PS4, Nintendo Switch, Pc",
                Publishers = new Publisher{ Name = "EA", Website = "ea.com" } }
            //new Videogame(3,"Uno Cards",10.15,"Stack of Cards","Two Players",new Publisher("Uno","uno.ca"),
            //    new Developer("Uno", "Uno"),new Genre("Cards", "Cards"),new Review("Carlos","Fun","Fun",6))
        };
        // GET: Cars - List of all Cars
        public ActionResult Index()
        {
            return View(videogamesList);
        }

        //Details
        public ActionResult Details(int? id)
        {
            if (id == null || id > videogamesList.Count)
            {
                return Content("Invalid VIdeogame ID");
            }
            var ind = Convert.ToInt32(id) - 1;
            var videogame = videogamesList[ind];
            return View(videogame);
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult Edit(int ID)
        {
            var vg = videogamesList.Where(v => v.ID == ID).FirstOrDefault();
            return View(vg);
        }

        [HttpPost]
        public ActionResult Edit( Videogame vg)
        {
            var Name = vg.Name;
            var Price = vg.Price;
            var Description = vg.Description;
            var MRequirements = vg.MinimumRequirements;

            return RedirectToAction("Index");
        }

    }
}


