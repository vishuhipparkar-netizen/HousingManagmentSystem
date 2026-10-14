using System;
using System.Collections.Generic;

namespace HousingManagmentSystem.Domain.Models;

public partial class FacilityImage
{
    public int FacilityImageId { get; set; }

    public int? FacilityId { get; set; }

    public string? Title { get; set; }

    public string? FacilityImage1 { get; set; }

    public int DisplayOrder { get; set; }

    public int? Flag { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public DateTime? RestoredAt { get; set; }

    public virtual Facility? Facility { get; set; }
}
