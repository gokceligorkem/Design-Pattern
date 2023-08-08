using ChainofResponsibilityDesignPat.DAL;
using ChainofResponsibilityDesignPat.Models;

namespace ChainofResponsibilityDesignPat.ChainofResponsibility
{
    public abstract class Employee
    {
        protected Employee NextApprover;
        public void SetNextApprover(Employee superVisor)//Sonraki onaylayıcı
        {
            this.NextApprover = superVisor;//Sıradaki onaylayıcı diğer çalışandan gelen değer.
        }
        public abstract void ProcessRequest(CustomerProcessViewModel request);
        
    }
}
