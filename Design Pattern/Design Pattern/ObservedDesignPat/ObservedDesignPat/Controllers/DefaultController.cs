using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ObservedDesignPat.DAL;
using ObservedDesignPat.Models;
using ObservedDesignPat.ObservedDesingPat;
using System.Threading.Tasks;

namespace ObservedDesignPat.Controllers
{
    public class DefaultController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ObserverObject _observerObject;

        public DefaultController(UserManager<AppUser> userManager, ObserverObject observerObject)
        {
            _userManager = userManager;
            _observerObject = observerObject;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel p)
        {
            var appUser = new AppUser()
            {
                Name = p.Name,
                Email = p.Email,
                Surname = p.Surname,
                UserName = p.Username,
                City="İstanbul",
                District="Küçükçekmece"

            };
           var result= await _userManager.CreateAsync(appUser, p.Password);
            if (result.Succeeded)
            {
                _observerObject.NotifyObserver(appUser);
                return View();
            }
            return View();
        }

    }
}
