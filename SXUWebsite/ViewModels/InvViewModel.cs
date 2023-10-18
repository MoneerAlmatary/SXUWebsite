using SXUWebsite.Models;
using System.ComponentModel.DataAnnotations;

namespace SXUWebsite.ViewModels
{
    public class InvViewModel
    {

        [Required(ErrorMessage = "You must provide a Valid SSN")]
        public int SSN { get; set; }


        [Required(ErrorMessage = "This Entry is Required")]
        [Display(Name = "FirstName")]
        public string InvFirstName { get; set; }
        [Required(ErrorMessage = "This Entry is Required")]
        [Display(Name = "SecondName")]
        public string InvSecondName { get; set; }
        [Required(ErrorMessage = "This Entry is Required")]
        [Display(Name = "LastName")]
        public string InvLastName { get; set; }
        [Required(ErrorMessage = "This Entry is Required")]
        [Display(Name = "Address")]
        public string InvAddress { get; set; }

        public string CountryCode { get; set; }

        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DisplayFormat(DataFormatString = "{0:###-###-###}")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid phone number")]
        public int phone { get; set; }

        [Required(ErrorMessage = "This Entry is Required")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This Entry is Required")]
        [Display(Name = "Date Of Birth")]
        public DateTime BOD { get; set; }

        [Required(ErrorMessage = "This Entry is Required")]
        [DataType(DataType.Currency)]
        public float TotalBalance { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
        public List<Stocks>? Stocks { get; set; }

        public bool STATUS { get; set; }


    }
}
