using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
   public class MaintainanceBillUpdateDto
    {
        [Required]
        public int MaintainanceId { get; set; }

        [Required]
        public string Id { get; set; } = null!;
        [Required]
        public int FlatId { get; set; }
        [Required]
        public int WingId { get; set; }
        [Required]
        public DateOnly? BillDate { get; set; }
        [Required]
        public DateTime? GeneratedAt { get; set; }

        [Required]

        public decimal? ParkingCharges { get; set; }
        [Required]
        public decimal? OtherCharges { get; set; }
        [Required]
        public DateOnly? Duedate { get; set; }
        [Required]
        public decimal? MaintainanceAmount { get; set; }
        [Required]
        public decimal? PaidAmount { get; set; }

        [Required]
        public decimal? UnpaidAmount { get; set; }
        [Required]
        public decimal? TotalAmount { get; set; }
        [Required]
        public string? Discount { get; set; }
        [Required]
        public decimal? Penalty { get; set; }
        [Required]
        public string? PayementStatus { get; set; }
        [Required]
        public string? PaymentMode { get; set; }
        [Required]
        public DateTime? PayementDate { get; set; }
        [Required]
        public string? TransactionReference { get; set; }
    }
}
