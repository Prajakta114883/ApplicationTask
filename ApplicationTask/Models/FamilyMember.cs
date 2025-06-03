using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class FamilyMember
{
    public int FamilyMemberId { get; set; }

    public int? ApplicantId { get; set; }

    public string? Name { get; set; }

    public string? Relationship { get; set; }

    public DateOnly? Dob { get; set; }

    public int? Age { get; set; }

    public virtual Applicant? Applicant { get; set; }
}
