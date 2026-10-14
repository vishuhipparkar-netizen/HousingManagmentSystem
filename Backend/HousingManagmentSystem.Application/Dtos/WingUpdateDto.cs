using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
    public class WingUpdateDto
    {
        [Required]
        public int WingId { get; set; }
        [Required]
        public string WingName { get; set; } = null!;
        [Required]
        public string WingCode { get; set; } = null!;
        [Required]
        public int NumberOfFloors { get; set; }
    }
}
