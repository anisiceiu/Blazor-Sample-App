using System.ComponentModel.DataAnnotations;

namespace UAM.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }
        [Required]
        public string? ApplicationName { get; set; }
        public Boolean isActive { get; set; }
        public ICollection<Table> Table { get; set;}
    }
}
