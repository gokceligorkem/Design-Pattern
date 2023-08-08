namespace DesignPatternComposite.Composite
{
    public interface IComponent
    {
        public int ID{ get; set; }
        public string Name { get; set; }
        int TotalCount();
        string Display();
    }
}
