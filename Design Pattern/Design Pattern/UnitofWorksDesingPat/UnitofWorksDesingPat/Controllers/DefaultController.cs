using DesingPatternBusinessLayer.Abstract;
using DesinPatternEntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using UnitofWorksDesingPat.Models;

namespace UnitofWorksDesingPat.Controllers
{
    public class DefaultController : Controller

    {
        private readonly ICustomerService _customerService;

        public DefaultController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel customerViewModel)
        {
           
            var value1 = _customerService.TGetById(customerViewModel.SenderID);
            var value2 = _customerService.TGetById(customerViewModel.RecevierID);
            value1.CustomerBalance -= customerViewModel.Amount;
            value2.CustomerBalance += customerViewModel.Amount;


            List<Customer> modifeCustomer = new List<Customer>()
            {
                value1,
                value2
            };
            _customerService.TMultiUpdate(modifeCustomer);
            return View();
        }
    }
}
