using EmployeeWeb2.BusinessLogic;
using EmployeeWeb2.Models.DataContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EmployeeWeb2.Models
{
    public class EmployeeViewModel
    {
        public UserViewModel user { get; set; }
        public PositionViewModel position { get; set; }
        [Display(Name = "Phone Number")]
        public string phone_number { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "Github User")]
        public string github_user { get; set; }
        [Display(Name = "Birth Date")]
        public string birth_date { get; set; }
        public string gender { get; set; }
        [Display(Name = "Gender")]
        public string gender_display { get { return gender.KeyToGender(); } set { race = value.GenderToKey(); } }
        public string race { get; set; }
        [Display(Name = "Race")]
        public string race_display { get { return race.KeyToRace(); } set { race = value.RaceToKey(); } }
        [Display(Name = "Years Worked")]
        public int years_worked { get; set; }
        [Display(Name = "Age")]
        public int age { get; set; }
        [Display(Name = "Days To Birthday")]
        public int days_to_birthday { get; set; }
    }
    public class UserViewModel
    {
        public int id { get; set; }
        [Display(Name = "Username")]
        public string username { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        [Display(Name = "First Name")]
        public string first_name { get; set; }
        [Display(Name = "Last Name")]
        public string last_name { get; set; }
        [Display(Name = "Active?")]
        public bool is_active { get; set; }
        [Display(Name = "Staff?")]
        public bool is_staff { get; set; }
        [Display(Name = "Superuser?")]
        public bool is_superuser { get; set; }
    }
    public class PositionViewModel
    {
        public int id { get; set; }
        [Display(Name = "Position")]
        public string name { get; set; }
        [Display(Name = "Level")]
        public string level { get; set; }
        [Display(Name = "Sort")]
        public int sort { get; set; }
    }
}