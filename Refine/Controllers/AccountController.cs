
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RefineModels.Models.Identity;
using System.Diagnostics;

namespace Demo.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;

            _signInManager = signInManager;

        }

        [HttpGet]
        public IActionResult Registration()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registration(RegisterUserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {

                ApplicationUser newuser = new ApplicationUser();

                newuser.UserName = userViewModel.Username;
                newuser.PasswordHash = userViewModel.Password;
        

                IdentityResult result = await _userManager.CreateAsync(newuser, userViewModel.Password);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(newuser, isPersistent: false);
                    return RedirectToAction("Index", "Student");
                }
                else
                {
                    foreach (var item in result.Errors)
                        ModelState.AddModelError("", item.Description);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult AdvanceLogin()
        {

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task< IActionResult> AdvanceLogin(LoginModelView loginuser)
        {
            if(ModelState.IsValid)
            {
             ApplicationUser User=  await _userManager.FindByNameAsync(loginuser.UsernameOrEmail);
                if (User == null)
                {
                    ModelState.AddModelError("", "No Matched User");
                }
                else
                {
                    bool found= await _userManager.CheckPasswordAsync(User, loginuser.Password);
                    if (found)
                    {
                        await _signInManager.SignInAsync(User, isPersistent: loginuser.RememberMe);
                        if ( User.UserName == "Amer")
                        {
                            return RedirectToAction("Categories", "Asr");
                        }
                      else if(User.UserName == "Anrpc")
                        {
                            return RedirectToAction("Categories", "Anrpc");
                        }
                        else
                        {
                            return RedirectToAction("Account", "AdvanceLogin");
                        }

                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid Password");
                       
                    }
                }

            }
            return View();
        }

    }
}
