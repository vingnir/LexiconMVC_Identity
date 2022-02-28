using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMVC_ViewModels.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
                
        public string FullName { get; set; }

        public string Email { get; set; }
                
        public string Subject { get; set; }

        public string UsrMessage { get; set; }
    }
}
