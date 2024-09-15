using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class Application
{
    public int ApplicationId { get; set; }

    public int? UserId { get; set; }

    public int? RequestId { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public string? Status { get; set; }

    public virtual VolunteerRequest? Request { get; set; }

    public virtual User? User { get; set; }
}
