using System;
using System.ComponentModel.DataAnnotations;

namespace TDU.CMS.Models
{
    public class Employee
    {
        [Key, Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Display(Name = "User Name", ShortName = "UserName")]
        public string UserName { get; set;}

        [Required,StringLength(6,MinimumLength = 4)]
        [Display(Name = "TellerID")]
        public string TellerID { get; set; }
        
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "DepartmentID",ShortName = "DeptID")]
        public long DeptID { get; set; }

        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return Name + " (" + TellerID + ")";
        }
    }
}
