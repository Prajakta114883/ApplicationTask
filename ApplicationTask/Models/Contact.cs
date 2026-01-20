using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Contact
{
    public int ContactId { get; set; }

    public int? ApplicantId { get; set; }

    public string? Name { get; set; }

    public string? CurrentCompany { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public virtual Applicant? Applicant { get; set; }
}
