using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
    public class CommiteeMemberCreateDto
    {
        [Required]
        public int CommiteeId { get; set; }
        [Required]
        public string Id { get; set; } = null!;
        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string? WorkingPeriod { get; set; }

        public string? HightligtedWork { get; set; }
    }
}
