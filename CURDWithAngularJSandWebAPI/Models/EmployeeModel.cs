using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CURDWithAngularJSandWebAPI.Models
{
    [Table("Employees")]
    public class EmployeeModel
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "First Name Required")]
        [StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = "Name should be between 3 to 20 characters")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
        public DateTime DOB { get; set; }

    }
}