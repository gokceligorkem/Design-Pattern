using ObservedDesignPat.DAL;

namespace ObservedDesignPat.ObservedDesingPat
{
    public class ObserverObject
    {
        private readonly List<IObserved> _observed = new List<IObserved>();

        public ObserverObject(List<IObserved> observed)
        {
            _observed = observed;
        }

        public ObserverObject()
        {
        }

        public void Register(IObserved observed)
        {
            _observed.Add(observed);
        }
        public void RemoveObserver(IObserved observed)
        {
            _observed.Remove(observed);
        }
        public void NotifyObserver(AppUser appuser)
        {
            _observed.ForEach(x =>
            {
                x.CreatedNewUser(appuser);    
            });
            
            
        }
    }
}
