using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Namespace
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Prefix { get; set; }

    public virtual ICollection<Type> Types { get; set; } = new List<Type>();
}
