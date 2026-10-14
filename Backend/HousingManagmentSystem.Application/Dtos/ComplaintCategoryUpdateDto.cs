using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
   public class ComplaintCategoryUpdateDto
    {
        [Required]
        public int ComplaintCategoryId { get; set; }
        
        [Required]
        public string Title { get; set; } = null!;

        public string? Description { get; set; }
    }
}
