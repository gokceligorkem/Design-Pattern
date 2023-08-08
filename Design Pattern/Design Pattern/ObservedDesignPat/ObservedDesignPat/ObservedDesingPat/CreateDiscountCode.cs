using ObservedDesignPat.DAL;

namespace ObservedDesignPat.ObservedDesingPat
{
    public class CreateDiscountCode : IObserved
    {
        private readonly IServiceProvider _serviceProvider;
        Context context = new Context();

        public CreateDiscountCode(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void CreatedNewUser(AppUser appuser)
        {
            context.Discounts.Add(new Discount
            {
                DiscountCode = "DERGİMART",
                DiscountAmount = 35,
                Status = true
            });
            context.SaveChanges();
        }
    }
}
