using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DutchGo.ViewModels
{
    
    public class ContactViewModel 
    {
        [Required]
        [MaxLength(5)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250, ErrorMessage = "To Long")]
        public string Message { get; set; }

    }
}
