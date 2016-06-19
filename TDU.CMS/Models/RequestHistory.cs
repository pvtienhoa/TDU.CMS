using System.ComponentModel.DataAnnotations;

namespace TDU.CMS.Models
{
    public class RequestHistory
    {
        [Key, Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required]
        [Display(Name = "CardID")]
        public long CardID { get; set; }

        public virtual Card Card { get; set; }

        [Required,StringLength(250)]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }}
