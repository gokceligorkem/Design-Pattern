using CQRSDesignPat.CQRSDesignPat.Command;
using CQRSDesignPat.CQRSDesignPat.Queries;
using CQRSDesignPat.CQRSDesignPat.Result;
using CQRSDesignPat.DAL;

namespace CQRSDesignPat.CQRSDesignPat.Handlers
{
    public class RemoveProductCommandHandler
    {
        private readonly Context _context;

        public RemoveProductCommandHandler(Context context)
        {
            _context = context;
        }

        public void Handler(RemoveProductCommand command)
        {
            var values = _context.Products.Find(command.ID);
            _context.Products.Remove(values);
            _context.SaveChanges();
        }
    }
}
