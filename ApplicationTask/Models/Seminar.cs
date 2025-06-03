using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Seminar
{
    public int SeminarId { get; set; }

    public int? ApplicationId { get; set; }

    public string? Title { get; set; }

    public string? ConductedBy { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public virtual Applicant? Application { get; set; }
}
