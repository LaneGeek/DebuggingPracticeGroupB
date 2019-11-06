
using Microsoft.AspNetCore.Mvc;

namespace HttpPractice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult HomeTown(string state, string city)
        {
            string content = "State: " + state + ", City: " + city; // Bug 3 fixed - changed from town to city
            return Content(content);
        }

        [HttpPost]
        public IActionResult Reading(string genre, string author, string book) // Bug 5 fixed - method should be Reading
        {
            return Content("Genre: " + genre + ", Author: " + book + ", Book: " + author);
        }

        [HttpPost]
        public IActionResult Vacation(string location, string activity, string clothing)
        {
            string content = "Location: " + location + ", Activity: " + activity + ", What to wear: " + clothing;
            return Content(content); //Bug 4 fixed - content is a variable, not a string literal!
        }

    }

}
