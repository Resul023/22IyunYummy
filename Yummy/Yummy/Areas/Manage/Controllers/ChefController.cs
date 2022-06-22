using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yummy.DAL;

namespace Yummy.Areas.Manage.Controllers
{
    public class ChefController : Controller
    {
        private readonly AppDbContext _context;

        public ChefController(AppDbContext context)
        {
            this._context = context;
        }
        public IActionResult Index()
        {
            var chef = _context.Chefs.ToList();
            return View(chef);
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
