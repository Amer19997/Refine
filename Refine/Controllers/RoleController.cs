
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RefineModels.Models.Identity;
using System.Diagnostics;
namespace Demo.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager=roleManager;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Role(RoleViewModel newrole)
        {

            if (ModelState.IsValid)
            {
                IdentityRole role = new IdentityRole();
                role.Name = newrole.RoleName;
               IdentityResult result = await _roleManager.CreateAsync(role);
                if(result.Succeeded)
                {
                    return View(new RoleViewModel());
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
           

            return View(newrole);
        }
    }
}
