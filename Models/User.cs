using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class User
{
    public int UserId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string? ProfilePicture { get; set; }

    public string? Bio { get; set; }

    public string UserType { get; set; } = null!;

    public DateTime? DateJoined { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<Review> ReviewRevieweds { get; set; } = new List<Review>();

    public virtual ICollection<Review> ReviewReviewers { get; set; } = new List<Review>();

    public virtual Volunteer? Volunteer { get; set; }

    public virtual ICollection<VolunteerRequest> VolunteerRequests { get; set; } = new List<VolunteerRequest>();
}
