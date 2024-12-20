using System;
using System.Collections.Generic;

namespace AKJ738_ZH3.Models;

public partial class BasicCompanyInfo
{
    public int InfoId { get; set; }

    public int TickerId { get; set; }

    public string Industry { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime FoundingDate { get; set; }

    public virtual Ticker Ticker { get; set; } = null!;
}
