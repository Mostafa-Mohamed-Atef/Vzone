using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class Organization
{
    public int OrganizationId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string? Website { get; set; }

    public string? ContactEmail { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? TaxId { get; set; }

    public DateTime? DateCreated { get; set; }

    public string? VerificationStatus { get; set; }

    public virtual ICollection<VolunteerRequest> VolunteerRequests { get; set; } = new List<VolunteerRequest>();
}
