using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.Concrete;
using DesignPattern.DataAccessLayer.Repository;
using DesinPatternEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.EntityFrameWork
{
    public class EfCustomerDal:GenericRepository<Customer>,ICustomerDAL
    {
        public EfCustomerDal(Context context ):base(context)
        {
                
        }
    }
}
