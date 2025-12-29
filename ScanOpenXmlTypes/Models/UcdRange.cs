using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class UcdRange
{
    public string StartCp { get; set; } = null!;

    public string? EndCp { get; set; }

    public int? BlockRange { get; set; }

    public string? RangeName { get; set; }

    public string? Standard { get; set; }

    public int? WritingSystemId { get; set; }

    public string? Language { get; set; }

    public string? Comment { get; set; }

    public virtual UcdBlock? BlockRangeNavigation { get; set; }
}
