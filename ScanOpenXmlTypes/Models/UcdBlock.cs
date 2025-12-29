using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class UcdBlock
{
    public int? Id { get; set; }

    public string? Range { get; set; }

    public string? BlockName { get; set; }

    public int? Start { get; set; }

    public int? End { get; set; }

    public int? WritingSystemId { get; set; }

    public string? Comment { get; set; }

    public virtual ICollection<UcdRange> UcdRanges { get; set; } = new List<UcdRange>();
}
