using CQRSDesignPat.CQRSDesignPat.Command;
using CQRSDesignPat.DAL;

namespace CQRSDesignPat.CQRSDesignPat.Handlers
{
    public class CreatProductCommandHandler
    {
        private readonly Context _context;

        public CreatProductCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreatedProductCommand p)
        {
            _context.Products.Add(new Product
            {
                ProductName = p.ProductName,
                Prica = p.Prica,
                ProductDescription = p.ProductDescription,
                Status = true,
                Stock = p.Stock,

            });
            _context.SaveChanges();
        }
    }
}
