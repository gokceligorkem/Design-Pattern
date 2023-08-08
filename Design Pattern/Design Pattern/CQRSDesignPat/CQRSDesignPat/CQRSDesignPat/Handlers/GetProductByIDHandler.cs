using CQRSDesignPat.CQRSDesignPat.Queries;
using CQRSDesignPat.CQRSDesignPat.Result;
using CQRSDesignPat.DAL;

namespace CQRSDesignPat.CQRSDesignPat.Handlers
{
    public class GetProductByIDHandler
    {
        private readonly Context _context;

        public GetProductByIDHandler(Context context)
        {
            _context = context;
        }
        public GetByIDQueryResult Handler(GetByIDQueryQuery query){
            var values = _context.Set<Product>().Find(query.ID);
            return new GetByIDQueryResult
            {
                ProductName = values.ProductName,
                Price = values.Prica,
                Stock = values.Stock,
                ID=values.ProductID
            };
        } 
    }
}
