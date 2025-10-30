using HRM.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Application.DTOs
{
    public class PlacementDto
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; } = string.Empty;
        public string EmployeeFullName { get; set; } = string.Empty;

        public DateTime AssignmentDate { get; set; }
        public string AssignmentDateEth { get; set; } = string.Empty;

        public DateTime? SalaryChangeDate { get; set; }
        public string? SalaryChangeDateEth { get; set; }

        public DateTime? NextSalaryChangeDate { get; set; }
        public string? NextSalaryChangeDateEth { get; set; }

        public int JobTitleId { get; set; }
        public string JobTitleName { get; set; } = string.Empty;

        public int OrgStructureId { get; set; }
        public int? ParentOrgStructureId { get; set; }

        public int MappingId { get; set; }

        public int RankId { get; set; }
        public string RankName { get; set; } = string.Empty;

        public int StepId { get; set; }
        public string StepName { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public AssignmentType AssignmentType { get; set; }
        public ResponsibilityLevel ResponsibilityLevel { get; set; }
        public EmployeeStatus EmploymentType { get; set; }

        public int ReportsTo { get; set; }
        public int ReportsToMappingId { get; set; }

        public int DepartmentId { get; set; }
        public int BranchId { get; set; }
        public int BusinessUnitId { get; set; }

        public string? Remark { get; set; }

        public bool IsCurrent { get; set; }
        public bool IsTemporary { get; set; }
        public bool IsHead { get; set; }
        public bool HaveFixedAsset { get; set; }

        public bool IsPending { get; set; }
        public bool IsEditable { get; set; }
        public bool IsApproved { get; set; }

        public int? ImmediateSupervisorId { get; set; }
        public int? HeadId { get; set; }

        public int ApprovedByEmployeeId { get; set; }
        public int PreparedByEmployeeId { get; set; }

        public double? Age { get; set; }

        public DateTime? HireDateGregorian { get; set; }
        public string? HireDateEth { get; set; }

        // Optional — useful for list views or API responses
        public string Summary => $"{EmployeeCode} - {JobTitleName} ({AssignmentType})";
    }

}
