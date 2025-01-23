using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace WABank.Models.ViewModels
{
    public class TransactionViewModel
    {
        public int TransactionVMId { get; set; } // Primary Key
        //---------------------------------------------------------------------------------------
        [DisplayName("Tranfer")]
        public int? TransferVM { get; set; } //
        //---------------------------------------------------------------------------------------
        public DateTime DateVM { get; set; } // Transaction date
        //---------------------------------------------------------------------------------------
        public decimal AmountVM { get; set; } // Total transaction amount 
        //---------------------------------------------------------------------------------------
        [DisplayName("User ID")]
        [ForeignKey("User")]
        public string UserId { get; set; } // Foreign Key to User
        public AppUser? User { get; set; } // Navigation property
    }
}
