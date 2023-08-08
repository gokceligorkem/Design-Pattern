namespace CQRSDesignPat.DAL
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public string ProductDescription { get; set; }
        public decimal Prica { get;set; }
        public bool Status { get; set; }
    }
}
