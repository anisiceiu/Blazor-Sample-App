using System.ComponentModel.DataAnnotations;

namespace UAM.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }

    }
}
