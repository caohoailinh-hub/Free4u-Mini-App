using System.ComponentModel.DataAnnotations;

namespace Free4u_Mini_App.Models
{
    public class Transactions
    {
        [Key]
        public string TransactionID { get; set; }        
        public DateTime JournalDate { get; set; }
        public DateTime VoucherDate { get; set; }
        public string VoucherNo { get; set; }
        public string Description { get; set; }
        public decimal TotalAmount { get; set; }
        public string PartnerID { get; set; }
        public string Person { get; set; }
        public string TransactionType { get; set; }
        public string PaymentMethod { get; set; }
        public string TransactionNote { get; set; }

    }
}
