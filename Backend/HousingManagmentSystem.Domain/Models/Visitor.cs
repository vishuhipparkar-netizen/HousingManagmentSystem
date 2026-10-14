using System;
using System.Collections.Generic;

namespace HousingManagmentSystem.Domain.Models;

public partial class Visitor
{
    public int VistorId { get; set; }

    public string? FullName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? VehicleNumber { get; set; }

    public string? VistorType { get; set; }

    public string? Purpose { get; set; }

    public DateTime? EntryTime { get; set; }

    public DateTime? ExitTime { get; set; }

    public string? Remarks { get; set; }
}
