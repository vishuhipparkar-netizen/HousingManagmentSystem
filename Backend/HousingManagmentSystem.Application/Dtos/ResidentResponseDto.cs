using HousingManagmentSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
   public class ResidentResponseDto
    {

        public int ResidentId { get; set; }

        public string FullName { get; set; } = null!;

        public string? Gender { get; set; }

        public string? Age { get; set; }

        public DateOnly? BirthDate { get; set; }

        public string PhoneNumber { get; set; } = null!;

        public string EmailAddress { get; set; } = null!;

        public int NumberOfMembers { get; set; }

        public string? ProfilePhoto { get; set; }

        public int FlatId { get; set; }

        public int WingId { get; set; }

        public string? ResidentType { get; set; }

        public DateTime MoveInDate { get; set; }

        public DateTime? MoveOutDate { get; set; }

        public bool IsPrimaryResident { get; set; }

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }

        public string Id { get; set; } = null!;

        
    }
}
