using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Education
{
    public int EdutionId { get; set; }

    public int? ApplicationId { get; set; }

    public string? Degree { get; set; }

    public string? Course { get; set; }

    public string? ProgramType { get; set; }

    public string? Elective { get; set; }

    public string? CollegeName { get; set; }

    public string? UniversityName { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public double? Percentage { get; set; }

    public DateOnly? GraduationDate { get; set; }

    public virtual Applicant? Application { get; set; }
}
