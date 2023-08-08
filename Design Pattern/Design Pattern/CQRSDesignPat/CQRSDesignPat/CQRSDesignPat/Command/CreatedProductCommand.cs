namespace CQRSDesignPat.CQRSDesignPat.Command
{
    public class CreatedProductCommand
    {
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string ProductDescription { get; set; }
        public decimal Prica { get; set; }

    }
}
