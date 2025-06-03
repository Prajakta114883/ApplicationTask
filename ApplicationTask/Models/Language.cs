using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Language
{
    public int LanguageId { get; set; }

    public int? ApplicationId { get; set; }

    public string? LanguageName { get; set; }

    public string? CanRead { get; set; }

    public string? CanWrite { get; set; }

    public string? CanSpeak { get; set; }

    public virtual Applicant? Application { get; set; }
}
