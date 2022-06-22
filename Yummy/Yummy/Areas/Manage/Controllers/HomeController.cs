using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yummy.Areas.Manage.Controllers
{
    public class HomeController : Controller
    {
        [Area("manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
