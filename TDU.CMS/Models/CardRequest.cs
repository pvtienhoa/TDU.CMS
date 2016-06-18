using System;
using System.ComponentModel.DataAnnotations;

namespace TDU.CMS.Models
{
    public enum RequestType
    {
        Issue,
        ReIssue,
        PinReset,
        Lock,
        Destroy,
        Extend
    }

    public enum RequestState
    {
        Producing,
        Received,
        Devided,
        InDept,
        Taken,
        Activated,
        Destroyed,
        Missing
    }

    public class CardRequest
    {
        [Key, Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required]
        [Display(AutoGenerateField = false)]
        public long CardID { get; set; }

        [Display(Name = "Card")]
        public virtual Card Card { get; set; }

        [EnumDataType(typeof(RequestType))]
        [Display(Name = "Request Type",ShortName = "ReqType")]
        public RequestType Type { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Request Date",ShortName = "ReqDate")]
        public DateTime RequestDate { get; set; }

        [Display(Name = "Card Location",ShortName = "CardLoc")]
        public int CardLocation { get; set; }

        [Display(Name = "Pin Location", ShortName = "PinLoc")]
        public int PinLocation { get; set; }

        [EnumDataType(typeof(RequestState))]
        [Display(Name = "State")]
        public RequestState State { get; set; }

        [StringLength(50)]
        [Display(Name = "Employee Name",ShortName = "Employee")]
        public string EmployeeName { get; set; }

        [StringLength(50)]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
