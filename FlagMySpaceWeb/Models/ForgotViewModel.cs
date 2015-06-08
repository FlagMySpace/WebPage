using System.ComponentModel.DataAnnotations;

namespace FlagMySpaceWeb.Models
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}