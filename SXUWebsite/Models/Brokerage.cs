using System.ComponentModel.DataAnnotations;

namespace SXUWebsite.Models
{
    public class Brokerage
    {
        [Key]
        public int ID { get; set; }


        [Required]
        [Display(Name = "CompanyName")]
        public string CompanyName { get; set; }



        [Required(ErrorMessage = "You must provide a phone number")]
        [Display(Name = "Phone")]
        [DisplayFormat(DataFormatString = "{0:###-###-####}")]
        

        [DataType(DataType.PhoneNumber)]
       [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessage = "Not a valid phone number")]
        public int Phone { get; set; }
         public string CountryCode { get; set; }    
     


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
        public string logoPath { get; set; }
 
        [Display(Name = "Liceinces")]
        public string Liceinces { get; set; }

        public bool Status { get; set; }
        public bool Approval { get; set; }

        public List<ListedCom>? ListedComs { get; set; }





    }
}
