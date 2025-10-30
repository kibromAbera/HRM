using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Domain.Enums
{

    public enum AssignmentType
    {
        [Display(Name = "Not Applicable")]
        NA = 0,

        [Display(Name = "New")]
        NEW,

        [Display(Name = "Promotion")]
        PROMOTION,

        [Display(Name = "Yearly Promotion")]
        YEARLY_PROMOTION,

        [Display(Name = "Transfer")]
        TRANSFER,

        [Display(Name = "Demotion")]
        DEMOTION,

        [Display(Name = "Recommendation")]
        RECOMMENDATION,

        [Display(Name = "Assignment")]
        ASSIGNMENT,

        [Display(Name = "Structure Change")]
        STRUCTURE_CHANGE,

        [Display(Name = "Annual Salary Increment")]
        ANNUAL_SALARY_INCREMENT,

        [Display(Name = "Temporary")]
        TEMPORARY,

        [Display(Name = "Rehire")]
        REHIRE,

        [Display(Name = "Job Title Change")]
        JOB_TITLE_CHANGE,

        [Display(Name = "Acting")]
        ACTING,

        [Display(Name = "Scale Promotion")]
        SCALE_PROMOTION
    }

    public enum ResponsibilityLevel
    {
        [Display(Name = "Not Applicable")]
        NA = 0,

        [Display(Name = "Top Management")]
        TOP_MANAGEMENT,

        [Display(Name = "Medium Management")]
        MEDIUM_MANAGEMENT,

        [Display(Name = "Low Management")]
        LOW_MANAGEMENT,

        [Display(Name = "Staff")]
        STAFF
    }

    public enum EmployeeStatus
    {
        [Display(Name = "Not Applicable")]
        NA = 0,

        [Display(Name = "Permanent")]
        PERMANENT = 1,

        [Display(Name = "Contract")]
        CONTRACT = 2,

        [Display(Name = "Probation")]
        PROBATION = 3,

        [Display(Name = "Freelancer")]
        FREELANCER = 4,

        [Display(Name = "No Status")]
        NO_STATUS = 5,

        [Display(Name = "Special")]
        SPECIAL = 6
    }


}
