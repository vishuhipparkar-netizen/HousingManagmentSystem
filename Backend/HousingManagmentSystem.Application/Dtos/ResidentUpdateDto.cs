using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
   public class ResidentUpdateDto
    {
        public int ResidentId { get; set; }

        [Required]
        public string FullName { get; set; } = null!;
        [Required]
        public string? Gender { get; set; }
        [Required]
        public string? Age { get; set; }
        [Required]
        public DateOnly? BirthDate { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = null!;
        [Required]
        public string EmailAddress { get; set; } = null!;

        public int NumberOfMembers { get; set; }
        [Required]
        public string? ProfilePhoto { get; set; }
        [Required]
        public int FlatId { get; set; }
        [Required]
        public int WingId { get; set; }
        [Required]
        public string? ResidentType { get; set; }
        [Required]
        public DateTime MoveInDate { get; set; }

        public DateTime? MoveOutDate { get; set; }

        public bool IsPrimaryResident { get; set; }
        public string Id { get; set; } = null!;
    }
}
