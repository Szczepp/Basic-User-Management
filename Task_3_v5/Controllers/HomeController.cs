using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Task_3_v5.Models;
using Task_3_v5.Areas.Identity.Data;

namespace Task_3_v5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        /*public async Task<IActionResult> BlockUsers(ApplicationUserModel users)
        {
            string returnUrl = Url.Content("~/Home/Privacy");
            foreach (string userId in users.UserId)
            {
                var user = await _userManager.FindByIdAsync(userId);
                user.Status = user.Status == "active" ? "blocked" : "active";
                await _userManager.UpdateAsync(user);
            }

            return LocalRedirect(returnUrl);
        }*/
    }
}
