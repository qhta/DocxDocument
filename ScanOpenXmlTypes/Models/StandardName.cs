using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class StandardName
{
    public string Code { get; set; } = null!;

    public byte? Ord { get; set; }

    public string? Name { get; set; }
}
