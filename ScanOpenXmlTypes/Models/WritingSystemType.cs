using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class WritingSystemType
{
    public string Type { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<WritingSystem> WritingSystems { get; set; } = new List<WritingSystem>();
}
