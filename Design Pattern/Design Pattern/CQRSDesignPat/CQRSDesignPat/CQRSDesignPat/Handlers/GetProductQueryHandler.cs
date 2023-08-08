using CQRSDesignPat.CQRSDesignPat.Result;
using CQRSDesignPat.DAL;
using System.Collections.Generic;
using System.Linq;

namespace CQRSDesignPat.CQRSDesignPat.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly Context _context;

        public GetProductQueryHandler(Context context)
        {
            _context = context;
        }
        public List<GetAllProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetAllProductQueryResult
            {
                ID = x.ProductID,
                ProductName = x.ProductName,
                Price = x.Prica,
                Stock = x.Stock
            }).ToList();
            return values;
        }
    }
}
