using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SXUWebsite.Models
{
    public class ListedCom 
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [Required]
        [Display(Name = "CompanyCode")]
        public string CompanyCode { get; set; }

        [Required]
        [Display(Name = "CompanyAddress")]
        public string CompanyAddress { get; set; }

        [Required]
        [Display(Name = "Website")]
        public string Website { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "logo")]
        public string? logoPath { get; set; }

        [Display(Name = "Liceinces")]
        public string? LiceincePath { get; set; }

        public bool STATUS { get; set; }
        public bool? Approval { get; set; }
        public DateTime? RegisterTime { get; set; }
        public List<Stocks>? Stocks { get; set; }

        public int CategoryFK { get; set; }

        [ForeignKey (nameof(CategoryFK))]   
        public virtual Category Category { get; set; }


    }
}
