using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class HtmlEntity
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public string? Glyph { get; set; }

    public bool? Default { get; set; }
}
