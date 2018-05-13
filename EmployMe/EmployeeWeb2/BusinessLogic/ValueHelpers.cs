using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeWeb2.BusinessLogic
{
    public static class ValueHelpers
    {
        public static Dictionary<string, string> RaceDictionary = new Dictionary<string, string>
        {
            { "B", "Black" },
            { "C", "Coloured" },
            { "I", "Indian_or_Asian" },
            { "W", "White" },
            { "N", "None_Dominant" },
        };
        public static string KeyToRace(this string value)
        {
            return RaceDictionary[value];
        }
        public static string RaceToKey(this string value)
        {
            return RaceDictionary.FirstOrDefault(x => x.Value == value).Key;
        }
        public static Dictionary<string, string> GenderDictionary = new Dictionary<string, string>
        {
            { "M", "Male" },
            { "F", "Female" },
        };
        public static string KeyToGender(this string value)
        {
            return GenderDictionary[value];
        }
        public static string GenderToKey(this string value)
        {
            return GenderDictionary.FirstOrDefault(x => x.Value == value).Key;
        }
        public static Dictionary<string, string> EmployeeReviewTypeDictionary = new Dictionary<string, string>
        {
            { "P", "Performance_Increase" },
            { "S", "Starting_Salary" },
            { "A", "Annual_Increase" },
            { "E", "Expectation_Review" },
        };
        public static string KeyToEmployeeReviewType(this string value)
        {
            return EmployeeReviewTypeDictionary[value];
        }
        public static string EmployeeReviewTypeToKey(this string value)
        {
            return EmployeeReviewTypeDictionary.FirstOrDefault(x => x.Value == value).Key;
        }
    }
}