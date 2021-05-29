using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniverseDB.DataBase;
using UniverseDB.DataBase.Entities;
using UniverseDB.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using UniverseDB.Models;

namespace UniverseDB.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GameController:Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment hostingEnvironment;
        public GameController(DataManager dataManager, IWebHostEnvironment hostingEnvironment)
        {
            this.dataManager = dataManager;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Add()
        {
            Game model = new Game();
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Game model, IFormFile imageFile)
        {
            //model.Id = dataManager.Games.GetGames().Count() + 1;
            if (ModelState.IsValid)
            {
                if (imageFile != null)
                {

                    //model.PicturePath
                    model.PicturePath = imageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/header/", imageFile.FileName), FileMode.Create))
                    {
                        imageFile.CopyTo(stream);
                    }
                }
                //
                dataManager.Games.SaveGame(model);
                return RedirectToAction(nameof(AdminController.Index), nameof(AdminController).CutController());
            }
            return View(model);
        }


        public IActionResult Edit(Guid id)
        {
            var model = id == default ? new Game() : dataManager.Games.GetGameById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Game model, IFormFile imageFile)
        {
            
            if (ModelState.IsValid)
            {
                if (imageFile != null)
                {
                    
                    //model.PicturePath
                    model.PicturePath = imageFile.FileName;
                    using (var stream = new FileStream(Path.Combine(hostingEnvironment.WebRootPath, "images/header/", imageFile.FileName), FileMode.Create)) 
                    {
                        imageFile.CopyTo(stream);
                    }
                }
                //
                dataManager.Games.SaveGame(model);
                return RedirectToAction(nameof(AdminController.Index), nameof(AdminController).CutController());
            }
            return View(model);
        }


    }
}
