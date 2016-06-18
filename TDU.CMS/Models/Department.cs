using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace TDU.CMS.Models
{
    public enum DepartmentType
    {
        HeadOffice,
        MainDept,
        SubDept,
        Customer
    }

    public class Department
    {
        [Key, Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required,StringLength(50)]
        [Display(Name = "Department Name", ShortName = "Name")]
        public string Name { get; set; }

        [Required]
        [DefaultValue(DepartmentType.SubDept)]
        [EnumDataType(typeof(DepartmentType))]
        [Display(Name = "Department Type", ShortName = "Type")]
        public DepartmentType Type { get; set; }

        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}