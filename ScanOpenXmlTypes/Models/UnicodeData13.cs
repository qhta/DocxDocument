using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class UnicodeData13
{
    public string Code { get; set; } = null!;

    public string? Description { get; set; }

    public string? Ctg { get; set; }

    public int? Comb { get; set; }

    public string? Bidir { get; set; }

    public string? Decomposition { get; set; }

    public string? DecDigitVal { get; set; }

    public string? DigitVal { get; set; }

    public string? NumVal { get; set; }

    public string? Mirr { get; set; }

    public string? OldDescription { get; set; }

    public string? Comment { get; set; }

    public string? Upper { get; set; }

    public string? Lower { get; set; }
}
