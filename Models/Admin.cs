using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public int? UserId { get; set; }

    public string Role { get; set; } = null!;

    public string? Permissions { get; set; }

    public DateTime? DateAssigned { get; set; }

    public virtual User? User { get; set; }
}
