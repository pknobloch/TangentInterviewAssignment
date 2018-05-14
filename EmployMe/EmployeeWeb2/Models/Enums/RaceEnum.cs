using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.BusinessLogic
{
    public enum RaceEnum
    {
        Black,
        Coloured,
        [Display(Name ="Indian or Asian")]
        Indian_or_Asian,
        White,
        [Display(Name = "None Dominant")]
        None_Dominant,
    }
}