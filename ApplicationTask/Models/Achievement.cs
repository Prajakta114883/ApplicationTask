using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Achievement
{
    public int AchievementId { get; set; }

    public int? ApplicationId { get; set; }

    public string? Description { get; set; }

    public int? Year { get; set; }

    public virtual Applicant? Application { get; set; }
}
