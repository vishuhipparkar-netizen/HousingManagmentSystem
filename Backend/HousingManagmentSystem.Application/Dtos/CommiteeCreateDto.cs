using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousingManagmentSystem.Domain.Models;

namespace HousingManagmentSystem.Application.Dtos
{
   
    public class CommiteeCreateDto
      
    {
        [Required]
        public string Position { get; set; } = null!;

        public string Description { get; set; } = null!;


    }
}
