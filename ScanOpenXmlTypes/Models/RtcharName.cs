using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class RtcharName
{
    public string Code { get; set; } = null!;

    public string? Name { get; set; }

    public string? AltName { get; set; }

    public string? Meaning { get; set; }

    public string? Description { get; set; }

    public string? BaseName { get; set; }

    public string? BaseCode { get; set; }
}
