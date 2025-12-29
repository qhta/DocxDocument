using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class RtcontrolWord
{
    public string Name { get; set; } = null!;

    public string? Meaning { get; set; }

    public int? Ctg { get; set; }

    public string? Uword { get; set; }

    public string? Uphrase { get; set; }

    public string? Description { get; set; }
}
