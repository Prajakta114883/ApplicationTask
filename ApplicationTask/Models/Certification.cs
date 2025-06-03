using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Certification
{
    public int CertificateId { get; set; }

    public int? ApplicationId { get; set; }

    public string? ProgramName { get; set; }

    public string? Institute { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public double? Percentage { get; set; }

    public string? Division { get; set; }

    public virtual Applicant? Application { get; set; }
}
