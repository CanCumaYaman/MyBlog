using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
  
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        /*
        public IActionResult Index2(int id)
        {
            var deger = c.articles.Find(id);

            
            return View(deger);
        }
        */
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Comments()
        {
            return View();
        }

    }
}
