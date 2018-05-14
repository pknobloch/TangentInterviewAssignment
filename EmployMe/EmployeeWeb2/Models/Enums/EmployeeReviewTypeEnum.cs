using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.BusinessLogic
{
    public enum EmployeeReviewTypeEnum
    {
        [Display(Name = "Performance Increase")]
        Performance_Increase,
        [Display(Name = "Starting Salary")]
        Starting_Salary,
        [Display(Name = "Annual Increase")]
        Annual_Increase,
        [Display(Name = "Expectation Review")]
        Expectation_Review,
    }
}