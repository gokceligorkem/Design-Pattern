using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DataAccessLayer.Abstract
{
    public interface IGenericDAL<T> where T : class
    {
        void insert (T t);
        void delete (T t);
        void update (T t);
        List<T>Getlist (T t);
        T GetById(int id);

         void MultiUpdate(List<T> t); 
    }
}
