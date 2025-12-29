using System;
using System.Collections.Generic;

namespace YourNamespace.Models;

public partial class Abbreviation
{
    public string Key { get; set; } = null!;

    public string? AbbrCat { get; set; }

    public string? Abbr { get; set; }

    public string? Ext { get; set; }

    public string? Code { get; set; }

    public string? Description { get; set; }

    public virtual AbbreviationCategory? AbbrCatNavigation { get; set; }
}
