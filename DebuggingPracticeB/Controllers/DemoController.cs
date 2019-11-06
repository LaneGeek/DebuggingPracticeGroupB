using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace HttpPractice.Controllers
{
    public class DemoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PageTwo(string mascot)
        {
            return View("PageTwo", mascot); // Bug 2 fixed
        }

        public IActionResult PageThree() => View(); // Bug 6 fixed - PageThree did not exist. Now it does.

        public IActionResult Quiz1()
        {
            Random rand = new Random();
            ViewBag.Number1 = rand.Next(100);
            ViewBag.Number2 = rand.Next(100);
            return View();
        }

        public IActionResult Quiz1Answer(string number1, string number2, string answer)
        {
            string check = "wrong :-(";
            if (int.Parse(number1) + int.Parse(number2) == int.Parse(answer))
                check = "right!";
            return Content(check);
        }

        [HttpGet] // Bug 8 fixed
        public IActionResult Quiz2()
        {
            Random rand = new Random();
            List<int> numbers = new List<int>();
            numbers.Add(rand.Next(10));
            numbers.Add(rand.Next(10));
            return View(numbers);
        }

        [HttpPost] // Bug 8 fixed
        public IActionResult Quiz2(int number1, int number2, int answer)
        {
            string check = "wrong :-(";
            if (number1 * number2 == answer)
                check = "right!";
            return Content(check);
        }
    }
}
