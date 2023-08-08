using CQRSDesignPat.CQRSDesignPat.Command;
using CQRSDesignPat.DAL;

namespace CQRSDesignPat.CQRSDesignPat.Handlers
{
    public class UpdateProductCommandHandler
    {
        private readonly Context _context;

        public UpdateProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handle(UpdateProductCommand command)
        {
            var values = _context.Products.Find(command.ProductID);
            values.ProductName = command.ProductName;
            values.ProductDescription = command.ProductDescription;
            values.Status = true;
            values.Stock = command.Stock;
            values.Prica = command.Prica;
            _context.SaveChanges ();
        }
    }
}
