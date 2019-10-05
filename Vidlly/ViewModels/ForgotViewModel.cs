using System.ComponentModel.DataAnnotations;

namespace Vidlly.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}