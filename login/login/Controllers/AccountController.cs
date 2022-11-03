using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using login.Models;

namespace login.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> Login(LoginModel loginModel)
    }
}
