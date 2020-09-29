using System.Threading.Tasks;
using BlogFront.ApiServices.Interfaces;
using BlogFront.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogFront.Controllers{
    public class AccountController : Controller{
        private readonly IAuthApiService _authApiService;
        public AccountController(IAuthApiService authApiService)
        {
            _authApiService = authApiService;
        }
        public IActionResult SignIn(){
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserLoginModel model){
            if(await _authApiService.SignIn(model)){
                return RedirectToAction("Index","Home",new {@area="Admin"});
            }

            return View();
        }
    }
}