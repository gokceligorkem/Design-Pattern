using CQRSDesignPat.CQRSDesignPat.Queries;
using CQRSDesignPat.CQRSDesignPat.Result;
using CQRSDesignPat.DAL;

namespace CQRSDesignPat.CQRSDesignPat.Handlers
{
    public class GetProductUpdateBYIDQUERYHANDLER
    {
        private readonly Context _context;

        public GetProductUpdateBYIDQUERYHANDLER(Context context)
        {
            _context = context;
        }
        public GetProductUpdateResult Handle(GetProductUpdateByIDQUERY query)
        {
            var values = _context.Products.Find(query.ID);
            return new GetProductUpdateResult
            {
                ProductID = values.ProductID,
                ProductName = values.ProductName,
                ProductDescription = values.ProductDescription,
                Prica = values.Prica,
                Stock = values.Stock,

            };
        }
    }
}
