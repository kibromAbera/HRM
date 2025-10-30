using System;

namespace HRM.Domain.Entities
{
    public class PersonEmployee
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FirstNameEnglish { get; set; } = string.Empty;
        public string MiddleNameEnglish { get; set; } = string.Empty;
        public string LastNameEnglish { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public string? DateOfBirthAm { get; set; }
        public DateTime HiredDate { get; set; }
        public string? HiredDateAm { get; set; }
        public bool IsActive { get; set; }
        public bool IsPlaced { get; set; }
        public bool IsReHired { get; set; }
        public string? Nationality { get; set; }
        public string? Remark { get; set; }
        public int BranchId { get; set; }
        public bool? IsProbationEnd { get; set; }

        public int? Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth.Date > today.AddYears(-age)) age--;
                return age;
            }
        }

        public string FullNameAmharic => $"{FirstName} {MiddleName} {LastName}";
        public string FullNameEnglish => $"{FirstNameEnglish} {MiddleNameEnglish} {LastNameEnglish}";
    }
}
