using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC_ViewModels.Models.ViewModels
{
    public class CreateMessageViewModel
    {
        [Display(Name = "Full Name")]
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string FullName { get; set; }

        [Display(Name = "Email address")]
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Email { get; set; }

        [Display(Name = "Subject")]
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string Subject { get; set; }

        [Display(Name = "Message")]
        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string UsrMessage { get; set; }
    }
}

