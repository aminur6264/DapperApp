using DapperApp.Models;
using DapperApp.Utilities;
using DapperCL.Module.HR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperApp.Controllers
{
    public class DapperController : Controller
    {
        private DapperDBContext db;
        public DapperController(DapperDBContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public IActionResult BulkInsert()
        {
            return View();
        }
        [HttpPost]
        public IActionResult BulkInsert(int insertQty)
        {
            DateTime startTime = DateTime.Now;
           string text =  new StringGenerator().RandomString(150);
            for (int i = 0; i < insertQty; i++)
            {
                Employee employee = new Employee()
                {
                    FirstName = text,
                    LastName = text,
                    DateOfBirth = startTime,
                    Email = text,
                    FatherName = text,
                    MotherName = text,
                    PhoneNumber = text
                };
                db.Employees.Add(employee);
            }
            db.SaveChanges();
            DateTime endTime = DateTime.Now;
            TimeSpan totalTime = endTime - startTime;
            string totalSecound = totalTime.Milliseconds.ToString();
            ViewBag.ExecutionTime = totalTime;
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
