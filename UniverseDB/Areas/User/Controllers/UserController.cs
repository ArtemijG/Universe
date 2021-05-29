using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverseDB.Areas.User.Controllers
{

    //[Authorize(Roles = "user")]
    [Area("user")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
