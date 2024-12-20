using System;
using System.Collections.Generic;

namespace AKJ738_ZH3.Models;

public partial class Ticker
{
    public int TickerId { get; set; }

    public string TickerSymbol { get; set; } = null!;

    public virtual ICollection<BasicCompanyInfo> BasicCompanyInfos { get; set; } = new List<BasicCompanyInfo>();

    public virtual ICollection<DailyPrice> DailyPrices { get; set; } = new List<DailyPrice>();
}
