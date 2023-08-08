using ObservedDesignPat.DAL;

namespace ObservedDesignPat.ObservedDesingPat
{
    public class CreateMagazineAnnocuncement : IObserved
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateMagazineAnnocuncement(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreatedNewUser(AppUser appuser)
        {
            context.UserProcesses.Add(new UserProcess
            {
                NameSurname = appuser.Name + " " + appuser.Name,
                Content = "Bilim dergimiz Ağustos sonunda evinizde ulaştırılacaktır.Konu; yeni teknolojiler insanlık için taşıdığı riskler",
                Magazin = "Some Value"
            });
            context.SaveChanges();  

        }
    }
}
