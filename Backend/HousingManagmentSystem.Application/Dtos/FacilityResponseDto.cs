using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
   public class FacilityResponseDto
    {
        public int FacilityId { get; set; }

        public string FacilityName { get; set; } = null!;

        public string? Description { get; set; }

        public int? Flag { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public DateTime? RestoredAt { get; set; }
    }
}
