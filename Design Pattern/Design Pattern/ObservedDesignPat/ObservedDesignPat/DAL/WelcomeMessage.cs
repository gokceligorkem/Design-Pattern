using System.ComponentModel.DataAnnotations;

namespace ObservedDesignPat.DAL
{
    public class WelcomeMessage
    {
        [Key]
        public int ID { get; set; }
        public string NameSurname { get; set; }
        public string Content { get; set; }
    }
}
