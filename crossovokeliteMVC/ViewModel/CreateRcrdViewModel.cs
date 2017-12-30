using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace crossovokeliteMVC.ViewModel
{
    public class CreateRcrdViewModel
    {
        [Required]
        [MaxLength(140, ErrorMessage = "Status cannot be more than 140 characters.")]
        public string Status { get; set; }
    }
}