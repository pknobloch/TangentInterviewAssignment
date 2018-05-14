using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.BusinessLogic
{
    public enum DateRangeEnum
    {
        Today = 1,
        [Display(Name = "Past 7 days")]
        Past_7_days = 2,
        [Display(Name = "This month")]
        This_month = 3,
        [Display(Name = "This year")]
        This_year = 4,
        Yesterday = 5,
    }
}