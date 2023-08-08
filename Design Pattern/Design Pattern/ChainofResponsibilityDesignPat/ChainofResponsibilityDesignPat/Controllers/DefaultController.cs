using ChainofResponsibilityDesignPat.ChainofResponsibility;
using ChainofResponsibilityDesignPat.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChainofResponsibilityDesignPat.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerProcessViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee regionalManager = new RegionalManager();

            treasurer.SetNextApprover(managerAssistant);
            managerAssistant.SetNextApprover(manager);
            manager.SetNextApprover(regionalManager);       
            treasurer.ProcessRequest(model);   
            return View(model);
        }
    }
}
