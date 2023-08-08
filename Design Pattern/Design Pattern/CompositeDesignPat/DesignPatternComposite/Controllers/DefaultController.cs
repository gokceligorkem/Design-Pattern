using DesignPatternComposite.Composite;
using DesignPatternComposite.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DesignPatternComposite.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var categories=_context.Categories.Include(x=>x.Products).ToList();
            var values = Rekursive(categories, new Category { CategoryName = "First Kategori", CategoryID = 0 }, new ProductComposite(0, "FirstComposite"));
            ViewBag.v1 = values;
            return View();
        }
        public ProductComposite Rekursive(List<Category> categories,Category firstcategory,ProductComposite firstComposite,ProductComposite leaf=null) 
        {
            categories.Where(x => x.ReferansID == firstcategory.CategoryID).ToList().ForEach(y =>
            {
                var productComposite = new ProductComposite(y.CategoryID, y.CategoryName);
                y.Products.ToList().ForEach(z =>
                {
                    productComposite.Add(new ProductComponent(z.ProductID, z.ProductName));
                });
                if (leaf != null)
                {
                    leaf.Add(productComposite);
                }
                else
                {
                    firstComposite.Add(productComposite);
                }
                Rekursive(categories, y, firstComposite, productComposite);
            });
            return firstComposite;
        }
    }
}
