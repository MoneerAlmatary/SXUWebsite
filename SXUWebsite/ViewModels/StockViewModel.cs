using System.ComponentModel.DataAnnotations;

namespace SXUWebsite.ViewModels
{
    public class StockViewModel
    {

        [Required]
        [Display(Name = "Company Capital")]
        public float Capital { get; set; }

        [Required]
        [Display(Name = "Stocks Number")]
        public int StockNum { get; set; }
        [Required]
        [Display(Name = "Stock Price")]
        public float StockPrice { get; set; }


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
