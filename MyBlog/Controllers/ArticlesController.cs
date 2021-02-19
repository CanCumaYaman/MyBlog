using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyBlog.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult SOLID()
        {
            return View();
        }
        public IActionResult OOP()
        {
            return View();
        }
        public IActionResult Clean_Code()
        {
            return View();
        }
        public IActionResult DesignPatterns()
        {
            return View();
        }
        public IActionResult Javascript()
        {
            return View();
        }
        public IActionResult Jquery()
        {
            return View();
        }
        public IActionResult Bootstrap()
        {
            return View();
        }
    }
}