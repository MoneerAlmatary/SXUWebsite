using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SXUWebsite.Models
{
    public class Stocks
    {
        [Key]
        public int StockId { get; set; }
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

        public int listedid { get; set; }

        [ForeignKey("listedid")]
        public virtual ListedCom ListedCom { get; set; }

        public Investors? investors { get; set; }


        [Display(Name = "Operation Date")]
        public DateTime OperationDate { get; set; }

        [Display(Name = "IPO Date")]
        public DateTime IPODate { get; set; }   

        public bool StockStatus { get; set; }
        


    }
}
