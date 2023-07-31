using Casgem_ObServer.DAL;
using Casgem_ObServer.Models;
using Casgem_ObServer.ObServerPattern;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_ObServer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _appUser;
        private readonly ObServerObject _obServerObject;

        public RegisterController(UserManager<AppUser> appUser, ObServerObject obServerObject)
        {
            _appUser = appUser;
            _obServerObject = obServerObject;
        }

        public async Task<IActionResult> Index(RegisterViewModel model)
        {
            var appuser = new AppUser()
            {
                Name = model.Name,
                Surname = model.Surname,
                City = model.City,
                Email = model.Email,
                District = model.District,
                UserName = model.UserName


            };
            var result = await _appUser.CreateAsync(appuser, model.Password);

            if (result.Succeeded)
            {
                _obServerObject.NotifyObServer(appuser);
                return View(result);
            }
                

            return View();
        }
    }
}
