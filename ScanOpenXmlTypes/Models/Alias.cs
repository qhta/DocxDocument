using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class Alias
{
    public int Ord { get; set; }

    public string Alias1 { get; set; } = null!;

    public byte? Type { get; set; }

    public virtual UnicodeDatum OrdNavigation { get; set; } = null!;
}
