using Microsoft.AspNetCore.Mvc;
using TemplateMethodDesignP.TemplatePattern;

namespace TemplateMethodDesignP.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult BasicplanIndex()
        {   
            Netflixplan netflixplan = new BasicPlan();
            netflixplan.CreatePlan();

            //ViewBag.v1=netflixplan.PlanType("Temel plan");
            //ViewBag.v2 = netflixplan.CountPerson(1);
            //ViewBag.v3=netflixplan.Price(64.99);
            //ViewBag.v4 = netflixplan.Content("Film-Dizi");
            //ViewBag.v5 = netflixplan.Resolution("480px");
            return View(netflixplan);
        }
        public IActionResult StandartPlanIndex()
        {
            Netflixplan netflixplan = new StandartPlan();

            return View(netflixplan);

        }
        public IActionResult UltraPlanIndex()
        {
            Netflixplan netflixplan = new UltraPlan();

            return View(netflixplan);

        }
    }
}
