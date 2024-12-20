using System;
using System.Collections.Generic;

namespace AKJ738_ZH3.Models;

public partial class DailyPrice
{
    public int Id { get; set; }

    public int TickerId { get; set; }

    public DateTime TradeDate { get; set; }

    public decimal OpenPrice { get; set; }

    public decimal ClosePrice { get; set; }

    public virtual Ticker Ticker { get; set; } = null!;
}
