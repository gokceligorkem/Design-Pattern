using DesignPattern.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPatternBusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        void Tinsert(T t);
        void Tdelete(T t);
        void Tupdate(T t);
        List<T> TGetlist(T t);
        T TGetById(int id);

        void TMultiUpdate(List<T> t);
    }
}
