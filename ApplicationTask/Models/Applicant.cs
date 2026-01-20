using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Applicant
{
    public int ApplicationId { get; set; }

    public string? Name { get; set; }

    public string? FatherName { get; set; }

    public string? Nationality { get; set; }

    public string? SocialSecurityNumber { get; set; }

    public string? Sex { get; set; }

    public string? MaritalStatus { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? PanCardNumber { get; set; }

    public string? EmailAddress { get; set; }

    public string? PhoneNo { get; set; }

    public virtual ICollection<Achievement> Achievements { get; set; } = new List<Achievement>();

    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();

    public virtual ICollection<Certification> Certifications { get; set; } = new List<Certification>();

    public virtual ICollection<Contact> Contacts { get; set; } = new List<Contact>();

    public virtual ICollection<Education> Educations { get; set; } = new List<Education>();

    public virtual ICollection<FamilyMember> FamilyMembers { get; set; } = new List<FamilyMember>();

    public virtual ICollection<Language> Languages { get; set; } = new List<Language>();

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<Seminar> Seminars { get; set; } = new List<Seminar>();
}
