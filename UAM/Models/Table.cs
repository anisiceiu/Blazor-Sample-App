using NuGet.Protocol.Core.Types;
using System.ComponentModel.DataAnnotations;

namespace UAM.Models
{
    public class Table
    {
        [Key]
        public int TableId { get; set; }
        [Required]
        public string? TableName { get; set; }
        public string? TableNameDesc { get; set; }
        public string? DBName { get; set; }
        public Boolean isActive { get; set; }
        public int ApplicationId { get; set; }
       // public Application? Application { get; set; }
     
    }
}
