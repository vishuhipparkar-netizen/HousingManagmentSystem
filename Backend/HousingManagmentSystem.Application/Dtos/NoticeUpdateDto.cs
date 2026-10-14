using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingManagmentSystem.Application.Dtos
{
    public class NoticeUpdateDto
    {
        [Required]
        public int NoticeId { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        public DateTime PublishDate { get; set; }
        [Required]
        public DateTime? ExpiryDate { get; set; }

        public string? Attachement { get; set; }

        public string? FeaturedImage { get; set; }
    }
}
