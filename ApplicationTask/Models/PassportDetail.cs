using System;
using System.Collections.Generic;

namespace ApplicationTask.Models;

public partial class PassportDetail
{
    public int PassportId { get; set; }

    public string? VisaStatus { get; set; }

    public string? WillingTarvalUsa { get; set; }

    public string? PassportIssu { get; set; }

    public DateOnly? PassportExpireDate { get; set; }

    public int? AddressId { get; set; }

    public virtual Address? Address { get; set; }
}
