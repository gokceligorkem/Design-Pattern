namespace CQRSDesignPat.CQRSDesignPat.Command
{
    public class UpdateProductCommand
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string ProductDescription { get; set; }
        public decimal Prica { get; set; }
    }
}
