using System.ComponentModel.DataAnnotations;

namespace crossovokeliteMVC.ViewModel
{
    public class CreateEagletViewModel
    {
        [Required]
        [MaxLength(140, ErrorMessage = "Status cannot be more than 140 characters.")]
        public string Status { get; set; }
    }
}