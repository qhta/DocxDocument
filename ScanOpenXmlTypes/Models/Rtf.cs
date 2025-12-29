using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class Rtf
{
    public int? Id { get; set; }

    public string? ControlWord { get; set; }

    public string? Section { get; set; }

    public string? Type { get; set; }

    public bool? V6 { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }
}
