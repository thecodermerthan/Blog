using BlogFront.Filters;
using Microsoft.AspNetCore.Mvc;

namespace BlogFront.Areas.Admin.Controllers{
    [Area("Admin")]
    public class HomeController : Controller{
        [JwtAuthorize]
        public IActionResult Index(){
            return View();
        }
    }
}