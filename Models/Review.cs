using System;
using System.Collections.Generic;

namespace Vzone_Project.Models;

public partial class Review
{
    public int ReviewId { get; set; }

    public int? ReviewerId { get; set; }

    public int? ReviewedId { get; set; }

    public string ReviewType { get; set; } = null!;

    public DateTime? ReviewDate { get; set; }

    public virtual User? Reviewed { get; set; }

    public virtual User? Reviewer { get; set; }
}
