using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class UnicodeDatum
{
    public int Ord { get; set; }

    public string? Glyph { get; set; }

    public string Code { get; set; } = null!;

    public string? CharName { get; set; }

    public string? Description { get; set; }

    public string? Ctg { get; set; }

    public double? Comb { get; set; }

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

    public string? Title { get; set; }

    public virtual ICollection<Alias> Aliases { get; set; } = new List<Alias>();
}
