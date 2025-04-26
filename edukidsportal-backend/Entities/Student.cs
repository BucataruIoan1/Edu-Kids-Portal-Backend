namespace edukidsportal_backend.Entities
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public int ParentId { get; set; }
        public int Grade { get; set; }
        public string? Race { get; set; }
        public string? Ethnicity { get; set; }
        public string? CountryOfBirth { get; set; }
        public string? Nationality { get; set; }
    }
}
