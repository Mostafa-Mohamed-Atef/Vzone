using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class VolunteerRequest
{
    public int RequestId { get; set; }

    public int? OrganizationId { get; set; }

    public int? RequesterId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? SkillsRequired { get; set; }

    public string? Location { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Status { get; set; }

    public DateTime? DatePosted { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Organization? Organization { get; set; }

    public virtual User? Requester { get; set; }
}
