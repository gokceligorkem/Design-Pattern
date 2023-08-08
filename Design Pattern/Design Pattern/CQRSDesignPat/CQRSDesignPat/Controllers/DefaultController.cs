using CQRSDesignPat.CQRSDesignPat.Command;
using CQRSDesignPat.CQRSDesignPat.Handlers;
using CQRSDesignPat.CQRSDesignPat.Queries;
using Microsoft.AspNetCore.Mvc;

namespace CQRSDesignPat.Controllers
{
    public class DefaultController : Controller
    {
        private readonly GetProductQueryHandler _handler;
        private readonly CreatProductCommandHandler _addhandler;
        private readonly GetProductByIDHandler _getProductByIDHandler;
        private readonly RemoveProductCommandHandler _removeProductCommandHandler;
        private readonly GetProductUpdateBYIDQUERYHANDLER _getProductUpdateBYIDQUERYHANDLER;
        private readonly UpdateProductCommandHandler _updateProductCommandHandler;
        public DefaultController(GetProductQueryHandler handler, CreatProductCommandHandler addhandler, GetProductByIDHandler getProductByIDHandler, RemoveProductCommandHandler removeProductCommandHandler, GetProductUpdateBYIDQUERYHANDLER getProductUpdateBYIDQUERYHANDLER, UpdateProductCommandHandler updateProductCommandHandler)
        {
            _handler = handler;
            _addhandler = addhandler;
            _getProductByIDHandler = getProductByIDHandler;
            _removeProductCommandHandler = removeProductCommandHandler;
            _getProductUpdateBYIDQUERYHANDLER = getProductUpdateBYIDQUERYHANDLER;
            _updateProductCommandHandler = updateProductCommandHandler;
        }

        public IActionResult Index()
        {
            var values = _handler.Handle();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProduct(CreatedProductCommand p)
        {
            _addhandler.Handle(p);
            return RedirectToAction("Index");
        }
        public IActionResult GetProduct(int id)
        {
            var values = _getProductByIDHandler.Handler(new GetByIDQueryQuery(id));
            return View(values);
        }
        public IActionResult DeleteProduct(int id)
        {
            _removeProductCommandHandler.Handler(new RemoveProductCommand(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            var values = _getProductUpdateBYIDQUERYHANDLER.Handle(new GetProductUpdateByIDQUERY(id));
            return View(values);

        }
        [HttpPost]
        public IActionResult UpdateProduct(UpdateProductCommand command)
        {
            _updateProductCommandHandler.Handle(command);
            return RedirectToAction("Index");
        }
    }
}
