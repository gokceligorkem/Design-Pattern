using ChainofResponsibilityDesignPat.DAL;
using ChainofResponsibilityDesignPat.Models;

namespace ChainofResponsibilityDesignPat.ChainofResponsibility
{
    public class RegionalManager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 410000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Bölge Direktörü - IMF";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
            }
            else 
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Bölge  Direktörü - IMF";
                customerProcess.Description = " Para çekme tutarı Bölge Direktörü günlük ödeyebileceği limiti aştığı için işlem gerçekleştirilemedi.Müşterinin Günlük Maksimum çekebileceği tutar 400.000₺ olup daha fazlası  için önümüzdeki günlerde gelmesi gereklidir.";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);

            }
        }
    }
}
