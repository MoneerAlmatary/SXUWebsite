using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SXUWebsite.Models
{

    public class ApplicationUser: IdentityUser
    {
        [Required]
        //  [DataType(DataType.Text)]

        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
       
        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }
        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
       /* public DateTime registerDate { get; set; }*/

    }
}
