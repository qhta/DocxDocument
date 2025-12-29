using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class WritingSystemKind
{
    public string Kind { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<WritingSystem> WritingSystems { get; set; } = new List<WritingSystem>();
}
