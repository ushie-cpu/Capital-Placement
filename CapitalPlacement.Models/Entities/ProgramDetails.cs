using CapitalPlacement.Models.Entities.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlacement.Models.Entities
{
    public class ProgramDetails :BaseEntity
    {
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        [Required]
        public string Description { get; set; }
        public string Skills { get; set; }
        public string Benefits { get; set; }
        public string Criteria { get; set; }
        public AdditionalInformation AdditionalInformation { get; set; }
    }

    public class AdditionalInformation
    {
        [ForeignKey("ProgramDetailsId")]
        public string ProgramDetailsId { get; set; }    
        [Required]
        public string ProgramType { get; set; }
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime ApplicationOpen { get; set; }
        [Required]
        public DateTime ApplicationClose { get; set; }
        public string Duration { get; set; }
        [Required]
        public string ProgramLocation { get; set; }
        public bool IsFullyRemote { get; set; }
        public string MinQualifications { get; set; }
        public int MaxNumberOfApplication { get; set; }
    }   
}
