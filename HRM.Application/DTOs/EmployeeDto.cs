using System;

namespace HRM.Application.DTOs
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string FullNameEnglish { get; set; } = string.Empty;
        public string FullNameAmharic { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }
        public int? Age { get; set; }
        public bool IsActive { get; set; }
    }
}
