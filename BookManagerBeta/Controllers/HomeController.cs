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
        BookContext db;

        public HomeController(BookContext context) => db = context;

        public ViewResult Index()
        {
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
                db.Books.Add(book);
                db.SaveChanges();
                return View("BookAdd", book);
            }
            else
            {
                return View();
            }
        }
        public IActionResult BookList()
        {
            return View(db.Books.ToList());
        }
    }
}
