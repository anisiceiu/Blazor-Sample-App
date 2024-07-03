using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UAM.Models
{
    public class Hose21mFittingVolume
    {
        [Key]
        public int Hose21mFittingVolumeID { get; set; }
        [Required]
        public string? Fitting { get; set; }
        [Required]
        public int FittingVolume { get; set; }        
        public Boolean isActive { get; set; }
        [NotMapped]
        public bool IsEditing{ get; set; }
    }
}

//Hose21mFittingVolumeID	Fitting	FittingVolume	isActive