using System.ComponentModel.DataAnnotations;
using SXUWebsite.Models;
namespace SXUWebsite.ViewModels
{
    public class ListedViewModel
    {
        public int CategoryID { get; set; }
        public string CatName { get; set; }
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
/*        [FileExtensions(ErrorMessage = "Select Images Only", Extensions = "jpg,png,jpeg,gif")]
*/
        public IFormFile logo { get; set; }

        [Display(Name = "Liceinces")]
/*        [FileExtensions(ErrorMessage = "Select Documents Only", Extensions = "pdf,doc,docs")]
*/
        public IFormFile Liceinces { get; set; }

        public bool STATUS { get; set; }

        public string? Approval { get; set; }
        public DateTime? RegisterTime { get; set; }


        [Display(Name = "logo")]
        public string? logoPath { get; set; }

        [Display(Name = "Liceinces")]
        public string? LiceincePath { get; set; }



        //stocks data



        [Required]
        [Display(Name = "Stock Price")]
        public float StockPrice { get; set; }
        [Required]
        [Display(Name = "Stock Number")]
        public int StockNum { get; set; }

        [Required]
        [Display(Name = "Capital")]
        public float Capital { get; set; }

        [Required]
        [Display(Name = "Stocks Available for Selling")]
        public int StocksForSell { get; set; }


        [Display(Name = "Operation Date")]
        public DateTime OperationDate { get; set; }

        [Display(Name = "IPO Date")]
        public DateTime IPODate { get; set; }

        public bool StockStatus { get; set; }

    }
}
