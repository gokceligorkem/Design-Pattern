using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.UnitofWork;
using DesingPatternBusinessLayer.Abstract;
using DesinPatternEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternBusinessLayer.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private readonly ICustomerDAL _customerDAL;
        private readonly IUowDal _IUowDAL;

        public CustomerManager(ICustomerDAL customerDAL, IUowDal ıUowDAL)
        {
            _customerDAL = customerDAL;
            _IUowDAL = ıUowDAL;
        }

        public void Tdelete(Customer t)
        {
            _customerDAL.delete(t);
            _IUowDAL.Save();
        }

        public Customer TGetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public List<Customer> TGetlist(Customer t)
        {
            return _customerDAL.Getlist(t);
        }

        public void Tinsert(Customer t)
        {
            _customerDAL.insert(t);
            _IUowDAL.Save();
        }

        public void TMultiUpdate(List<Customer> t)
        {
            _customerDAL.MultiUpdate(t);
            _IUowDAL.Save();
        }

        public void Tupdate(Customer t)
        {
            _customerDAL.update(t);
            _IUowDAL.Save();
        }
    }
}
