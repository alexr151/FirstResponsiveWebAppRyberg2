using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstResponsiveWebAppRyberg.Models
{
    public class AgeCalculator
    {

        [Required(ErrorMessage = "Please enter your first name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter what year you were born")]
        [Range(1910, 2021, ErrorMessage = "Please enter a year between 1910 and now")]
        public int? DOB { get; set; }
        public int? AgeThisYear()
        {
            System.DateTime moment = DateTime.Now;

            int? result = moment.Year - DOB;
            return result;
        }
    }
}
