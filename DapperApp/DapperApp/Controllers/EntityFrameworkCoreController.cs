using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperApp.Controllers
{
    public class EntityFrameworkCoreController : Controller
    {
        [HttpGet]
        public IActionResult BulkInsert()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Read()
        { 
            return View();
        }
        [HttpGet]
        public IActionResult BulkAyncInsert()
        {
            return View();
        }
    }
}
