using System.ComponentModel.DataAnnotations;

namespace SXUWebsite.Models
{
    public class ContactUs
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }

       

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]

        public string Email { get; set; }



      
    }
}
