using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class Address
{
    public int AddressId { get; set; }

    public string? HouseNo { get; set; }

    public string? Locality { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Pincode { get; set; }

    public string? PeriodOfStay { get; set; }

    public int? ApplicationId { get; set; }

    public virtual Applicant? Application { get; set; }
}
