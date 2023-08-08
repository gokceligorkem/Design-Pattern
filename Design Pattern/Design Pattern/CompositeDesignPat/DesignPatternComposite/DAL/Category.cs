namespace DesignPatternComposite.DAL
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public int ReferansID { get; set; }

        public List<Product> Products { get; set; }
    }
}
