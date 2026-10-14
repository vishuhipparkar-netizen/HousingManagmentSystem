using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
   
    public class CommiteeUpdateDto
    {
        [Required]
        public int CommiteeId { get; set; }

        [Required]
        public string Position { get; set; } = null!;

        public string? Description { get; set; }
    }
}
