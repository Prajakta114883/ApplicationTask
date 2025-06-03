using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Project
{
    public int ProjectId { get; set; }

    public int? ApplicationId { get; set; }

    public string? Title { get; set; }

    public string? Company { get; set; }

    public string? Client { get; set; }

    public string? SkillsUsed { get; set; }

    public string? Platform { get; set; }

    public int? TeamSize { get; set; }

    public string? Role { get; set; }

    public virtual Applicant? Application { get; set; }
}
