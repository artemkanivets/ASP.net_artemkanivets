using lab_1_asp_net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using lab_1_asp_net.Resources;
using Microsoft.Extensions.Localization;

namespace lab_1_asp_net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IStringLocalizer<Texts> _localizer;

        public HomeController(ILogger<HomeController> logger, IStringLocalizer<Texts> localizer)
        {
            _logger = logger;
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            var users = DataEmulator.Users;
            ViewBag.Користувачі = _localizer["Користувачі"].Value;
            return View(users);
        }

        public IActionResult CreateUser()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateUser(User user)
        {
            if (ModelState.IsValid)
            {
                
                DataEmulator.Users.Add(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        public IActionResult EditUser(int id)
        {
            var user = DataEmulator.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View("EditUser", user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditUser(User user)
        {
            if (ModelState.IsValid)
            {
                var existingUser = DataEmulator.Users.FirstOrDefault(u => u.Id == user.Id);
                if (existingUser != null)
                {
                    existingUser.Id = user.Id;
                    existingUser.FullName = user.FullName;
                    existingUser.Email = user.Email;
                    existingUser.Address = user.Address;
                    existingUser.PhoneNumber = user.PhoneNumber;
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    return NotFound();
                }
            }
            return View(user);
        }
        public IActionResult DeleteUser(int id)
        {
            var user = DataEmulator.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var user = DataEmulator.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                DataEmulator.Users.Remove(user);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Privacy()
        {
            var movie = DataEmulator.Movies;
            return View(movie);
        }

        public IActionResult CreateMovie()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateProd(Movie movie)
        {
            if (ModelState.IsValid)
            {
                
                DataEmulator.Movies.Add(movie);
                return RedirectToAction(nameof(Privacy));
            }
            return Redirect(ViewBag.ReturnUrl);
            

        }

        public IActionResult EditMovie(int id)
        {
            var movies = DataEmulator.Movies.FirstOrDefault(p => p.Id == id);
            if (movies == null)
            {
                return NotFound();
            }
            return View(movies);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var existingMovie = DataEmulator.Movies.FirstOrDefault(m => m.Id == movie.Id);
                if (existingMovie != null)
                {
                    // Оновити існуючий продукт
                    existingMovie.Name = movie.Name;
                    existingMovie.Description = movie.Description;
                    existingMovie.Price = movie.Price;
                    return RedirectToAction(nameof(Privacy));
                }
                else
                {
                    return NotFound();
                }
            }
            return View(movie);
        }

        public IActionResult DeleteMovie(int id)
        {
            var movie = DataEmulator.Movies.FirstOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            return View(movie);
        }

        [HttpPost, ActionName("DeleteMovie")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed_Movie(int id)
        {
            var movie = DataEmulator.Movies.FirstOrDefault(p => p.Id == id);
            if (movie != null)
            {
                
                DataEmulator.Movies.Remove(movie);
                return RedirectToAction(nameof(Privacy));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Order()
        {
            var orders = DataEmulator.Orders;
            return View(orders);
        }

        public IActionResult CreateOrder()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                
                DataEmulator.Orders.Add(order);
                return RedirectToAction(nameof(Order));
            }
            return View(order);
        }

        public IActionResult EditOrder(int id)
        {
            var order = DataEmulator.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return View("EditOrder", order); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditOrder(Order order)
        {
            if (ModelState.IsValid)
            {
                var existingOrder = DataEmulator.Orders.FirstOrDefault(o => o.Id == order.Id);
                if (existingOrder != null)
                {
                    existingOrder.Id = order.Id;
                    existingOrder.UserId = order.UserId;
                    existingOrder.MovieName = order.MovieName;
                    existingOrder.TotalPrice = order.TotalPrice;
                    return RedirectToAction(nameof(Order));
                }
                else
                {
                    return NotFound();
                }
            }
            return View(order);
        }

        public IActionResult DeleteOrder(int id)
        {
            var order = DataEmulator.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        [HttpPost, ActionName("DeleteOrder")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed_Order(int id)
        {
            var order = DataEmulator.Orders.FirstOrDefault(o => o.Id == id);
            if (order != null)
            {
                
                DataEmulator.Orders.Remove(order);
                return RedirectToAction(nameof(Order));
            }
            else
            {
                return NotFound();
            }
        }








    }
}
