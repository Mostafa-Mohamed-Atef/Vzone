using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class Volunteer
{
    public int VolunteerId { get; set; }

    public string? Skills { get; set; }

    public string? Experience { get; set; }

    public string? Location { get; set; }

    public string? Reviews { get; set; }

    public virtual User VolunteerNavigation { get; set; } = null!;
}
