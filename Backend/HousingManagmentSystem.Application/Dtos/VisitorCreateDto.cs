using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
    public class VisitorCreateDto
    {
        [Required]
        public int FlatId { get; set; }
        [Required]
        public string? FullName { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
        [Required]
        public string? VehicleNumber { get; set; }
        [Required]
        public string? VistorType { get; set; }
        [Required]
        public string? Purpose { get; set; }
          [Required]
        public DateTime? EntryTime { get; set; }
        [Required]
        public DateTime? ExitTime { get; set; }

    }
}
