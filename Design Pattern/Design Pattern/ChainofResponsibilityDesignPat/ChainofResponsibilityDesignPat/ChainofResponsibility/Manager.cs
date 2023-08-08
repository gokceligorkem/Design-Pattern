using ChainofResponsibilityDesignPat.DAL;
using ChainofResponsibilityDesignPat.Models;

namespace ChainofResponsibilityDesignPat.ChainofResponsibility
{
    public class Manager : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 170000)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Şube Müdürü  - Serpil Gökçeli";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover != null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Şube Müdürü  - Serpil Gökçeli";
                customerProcess.Description = "Para çekme işlemi onaylanmadı. Para çekme tutarı Şube Müdür Yardımcısı günlük ödeyebileceği limiti aştığı için işlem şube müdürüne yönlendirildi.";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);

            }
        }
    }
}
