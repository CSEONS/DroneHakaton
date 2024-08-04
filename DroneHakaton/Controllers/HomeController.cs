using DroneHakaton.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DroneHakaton.Controllers
{
    public class HomeController : Controller
    {
        private static string _record= "12:329";
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Courses()
        {
            return View();
        }

        public IActionResult CourseDetails()
        {
            return View();
        }

        public IActionResult AdminPanel()
        {
            return View();
        }

        public IActionResult EditCourse()
        {
            return View();
        }
        public IActionResult CreateCourse()
        {
            return AdminPanel();
        }

        [HttpPost("SetRecord")]
        public IActionResult SetRecord([FromForm] string record)
        {
            Console.WriteLine(Request);
            _record = record;
            return Ok();
        }

        public IActionResult Module(Guid courseId, Guid moduleId)
        {
            Console.WriteLine($"{courseId}\n{moduleId}");
            return View();
        }

        [HttpGet("Msss")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Profile()
        {
            ViewBag.record = _record;
            return View();
        }

        [HttpPost("Message")] //http://10.3.0.117:5266/Message
        public IActionResult SendMessage([FromForm] string message)
        {
            Console.WriteLine(message);
            return Ok();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
