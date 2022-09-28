using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Task_3_v5.Areas.Identity.Data;
using System.Collections.Generic;
using System.Collections;
using Task_3_v5.Models;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace Task_3_v5.Controllers
{
    public class ApplicationUserController : Controller
    {

        private  UserManager<ApplicationUser> _userManager;
        private  ILogger<ApplicationUser> _logger;


        public ApplicationUserController(UserManager<ApplicationUser> userManager,
            ILogger<ApplicationUser> logger)
        {
            _userManager = userManager;
            _logger = logger;
        }

        // GET: ApplicationUserController
        public ActionResult Index()
        {
            //ApplicationUserModel user = new ApplicationUserModel();
            return View();
        }

        // GET: ApplicationUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApplicationUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApplicationUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApplicationUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApplicationUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Block(string[] UserId)
        {
            
                foreach(string id in UserId)
                {
                    if (id.Length < 6 ) break;
                    var user = await _userManager.FindByIdAsync(id);
                    user.Status = "blocked";
                    await _userManager.UpdateAsync(user);
                }
                return LocalRedirect("~/ApplicationUser");
            
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Unblock(string[] UserId)
        {
            foreach (string id in UserId)
            {
                if (id.Length < 6) break;
                var user = await _userManager.FindByIdAsync(id);
                user.Status = "active";
                await _userManager.UpdateAsync(user);
            }
            return LocalRedirect("~/ApplicationUser");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string[] UserId)
        {
            foreach (string id in UserId)
            {
                if (id.Length < 6) break;
                var user = await _userManager.FindByIdAsync(id);
                await _userManager.DeleteAsync(user);
            }
            return LocalRedirect("~/ApplicationUser");
        }
    }
}
