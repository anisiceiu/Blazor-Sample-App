using System.ComponentModel.DataAnnotations;

namespace UAM.Models
{
    public class tbl_Rev_per_Material
    {
        [Required]
        public string? Material { get; set; }
        public string? Rev { get; set; }
    }
}
 

