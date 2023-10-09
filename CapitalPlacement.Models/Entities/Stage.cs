using System.ComponentModel.DataAnnotations.Schema;

namespace CapitalPlacement.Models.Entities
{
    public class Stage
    {
        public string Name { get; set; }
        public string StageType { get; set; }
        public VideoQuestions VideoQuestions { get; set; }
    }

    public class VideoQuestions
    {
        [ForeignKey("StageId")]
        public string StageId { get; set; }   
        public string InterviewQuestion { get; set; }
        public string AdditionalInfo { get; set; }
        public int Duration { get; set; }
        public string DateLine { get; set; }
    }  
}
