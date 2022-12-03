using BookStore.Models;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        //private readonly UserManager<DefaultUser> _userManager;

        public AdminController(RoleManager<IdentityRole> roleManager/*, UserManager<DefaultUser> userManager*/)
        {
            _roleManager = roleManager;
            //_userManager = userManager;
        }

        [HttpGet]
        public IActionResult ListAllRoles()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
    }
}
