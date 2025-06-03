using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class TblReference
{
    public int ReferenceId { get; set; }

    public int? ApplicationId { get; set; }

    public string? Name { get; set; }

    public string? CurrentCompany { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public virtual Applicant? Application { get; set; }
}
