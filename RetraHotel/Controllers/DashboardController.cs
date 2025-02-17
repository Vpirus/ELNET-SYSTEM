using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RetraHotel.Controllers
{
    [Authorize(Roles = "Admin, Staff")] // Restrict access to Admins and Staff
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Rooms()
        {
            return View();
        }

        public IActionResult Bookings()
        {
            return View();
        }

        public IActionResult Guests()
        {
            return View();
        }
    }
}