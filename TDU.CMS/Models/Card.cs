using System;
using System.ComponentModel.DataAnnotations;

namespace TDU.CMS.Models
{
    public class Card
    {
        [Key,Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required,StringLength(30,MinimumLength = 4)]
        [Display(Name = "Card Number", ShortName = "CardNo")]
        public string CardNumber { get; set; }

        [Required, StringLength(30, MinimumLength = 4)]
        [Display(Name = "Card Holder",ShortName = "CardHol")]
        public string CardHolder { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Issue Date", ShortName = "IssuDate")]
        public DateTime IssueDate { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Expire Date", ShortName = "ExpDate")]
        public DateTime ExpireDate { get; set; }

        [Required, StringLength(9)]
        [Display(Name = "Cif No", ShortName = "Cif")]
        public string Cif { get; set; }
    }
}
