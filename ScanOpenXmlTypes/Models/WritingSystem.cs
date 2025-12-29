using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class WritingSystem
{
    public int? Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Type { get; set; }

    public int? ParentId { get; set; }

    public string? Kind { get; set; }

    public bool? Starting { get; set; }

    public string? Keywords { get; set; }

    public string? Ctg { get; set; }

    public string? Iso { get; set; }

    public string? Abbr { get; set; }

    public string? Ext { get; set; }

    public string? Description { get; set; }

    public string? Aliases { get; set; }

    public virtual ICollection<WritingSystem> InverseParent { get; set; } = new List<WritingSystem>();

    public virtual WritingSystemKind? KindNavigation { get; set; }

    public virtual WritingSystem? Parent { get; set; }

    public virtual WritingSystemType? TypeNavigation { get; set; }
}
