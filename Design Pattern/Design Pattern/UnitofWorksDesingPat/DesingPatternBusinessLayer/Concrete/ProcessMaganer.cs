using DesignPattern.DataAccessLayer.Abstract;
using DesignPattern.DataAccessLayer.EntityFrameWork;
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
    public class ProcessMaganer : IProcessService
    {
        private readonly IProcessDAL _processDAL;
        private readonly IUowDal _IUowDAL;

        public ProcessMaganer(IProcessDAL processDAL, IUowDal ıUowDAL)
        {
            _processDAL = processDAL;
            _IUowDAL = ıUowDAL;
        }

        public void Tdelete(Process t)
        {
            _processDAL.delete(t);
            _IUowDAL.Save();
        }

        public Process TGetById(int id)
        {
            return _processDAL.GetById(id);
        }

        public List<Process> TGetlist(Process t)
        {
            return _processDAL.Getlist(t);
        }

        public void Tinsert(Process t)
        {
            _processDAL.insert(t);
            _IUowDAL.Save();
        }

        public void TMultiUpdate(List<Process> t)
        {
            _processDAL.MultiUpdate(t);
            _IUowDAL.Save();
        }

        public void Tupdate(Process t)
        {
            _processDAL.update(t);
            _IUowDAL.Save();
        }
    }
}
