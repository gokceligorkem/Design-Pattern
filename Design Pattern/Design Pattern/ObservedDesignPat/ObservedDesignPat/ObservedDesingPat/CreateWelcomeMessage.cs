using ObservedDesignPat.DAL;

namespace ObservedDesignPat.ObservedDesingPat
{
    public class CreateWelcomeMessage : IObserved
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateWelcomeMessage(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void CreatedNewUser(AppUser appuser)
        {
            context.WelcomeMessages.Add(new WelcomeMessage
            {
                NameSurname= appuser.Name+" "+appuser.Surname,
                Content="Kayıt olduğunuz için teşekkür ederiz.Hoşgeldiniz."
            });
            context.SaveChanges();
        }
    }
}
