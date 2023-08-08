using ChainofResponsibilityDesignPat.DAL;
using ChainofResponsibilityDesignPat.Models;

namespace ChainofResponsibilityDesignPat.ChainofResponsibility
{
    public class Treasurer : Employee
    {
        public override void ProcessRequest(CustomerProcessViewModel request)
        {
            Context context = new Context();
            if (request.Amount <= 270000)
            {
                CustomerProcess customerProcess=new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Şube Müdürü - RTE";
                customerProcess.Description = "Para çekme işlemi onaylandı. Müşterinin talep ettiği tutar ödendi.";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
            }
            else if (NextApprover!=null)
            {
                CustomerProcess customerProcess = new CustomerProcess();
                customerProcess.Amount = request.Amount.ToString();
                customerProcess.CustomerName = request.CustomerName;
                customerProcess.EmployeeName = "Şube Müdürü - RTE";
                customerProcess.Description = "Para çekme işlemi onaylanmadı. Para çekme tutarı Şube Müdürünün  günlük ödeyebileceği limiti aştığı için işlem  Bölge Müdürüne yönlendirildi.";
                context.CustomerProcess.Add(customerProcess);
                context.SaveChanges();
                NextApprover.ProcessRequest(request);

            }
        }
    }
}
