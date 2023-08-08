using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntitiyleLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProdutcDal : GenericRepository<Product>, IProductDal
    {
        public EfProdutcDal(Context context) : base(context)
        {
        }
    }
}
