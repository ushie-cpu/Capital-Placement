using CapitalPlacement.Models.Entities.Shared;

namespace CapitalPlacement.Models.Entities
{
    public class ApplicationForm :BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string EmailAddress { get; set; }
        public string ImageUrl { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsInternal { get; set; }
        public string Nationality { get; set; }
        public string CurrentResidence { get; set; }
        public string IdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MyProperty { get; set; }
    }

    public class Profile :BaseEntity
    {
        public Education Education { get; set; }
        public WorkExperience Experience { get; set; }
        public string Resume { get; set; }
    } 
    

    public class Education :BaseEntity  
    {
        public string School { get; set; }
        public string Degree { get; set; }
        public string CourseName { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
    public class WorkExperience :BaseEntity 
    {
        public string Company { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class AdditionalQuestions
    {
        public string About { get; set; }
        public DateTime YearOfGraduation { get; set; }
        public string QuestionType { get; set; }
        public string Choice { get; set; }
        public bool UkRejected { get; set; }
    }
}
