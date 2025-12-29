using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class LatexMath
{
    public string Code { get; set; } = null!;

    public string? Tex { get; set; }
}
