using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookManagerBeta.Models;

namespace BookManagerBeta.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

            return View("MyView");
        }

        [HttpGet]
        public ViewResult BookForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult BookForm(Book book)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(book);
                return View("BookAdd", book);
            }
            else
            {
                return View();
            }
        }

        public ViewResult BookList()
        {
            return View(Repository.Responses);
        }
    }
}
