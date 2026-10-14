using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
    public class SocietyCreateDto
    {
        [Required]
        public string SocietyName { get; set; } = null!;
        [Required]
        public DateTime? EstablishedDate { get; set; }
        [Required]
        public string? DevelopedBy { get; set; }
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;
        [Required]
        public string State { get; set; } = null!;

        public string? Pincode { get; set; }
        [Required]
        public string Phone { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string? Logo { get; set; }

        public string? Description { get; set; }
    }
}
