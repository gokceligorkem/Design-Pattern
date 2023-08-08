namespace CQRSDesignPat.CQRSDesignPat.Command
{
    public class RemoveProductCommand
    {
        public RemoveProductCommand(int ıD)
        {
            ID = ıD;
        }

        public int ID { get; set; }
    }
}
