using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WABank.Models.ViewModels
{
    public class TransferViewModel
    {
        [DisplayName("Sender ID")]
        [Required(ErrorMessage = "*Sender ID is required")]
        public string SenderId { get; set; }

        [DisplayName("Receiver ID")]
        [Required(ErrorMessage = "*Receiver ID is required")]
        public string ReceiverId { get; set; }

        [DisplayName("Amount")]
        [Required(ErrorMessage = "*Amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "*Amount must be greater than zero")]
        public decimal Amount { get; set; }
    }
}
