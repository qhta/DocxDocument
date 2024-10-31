using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class NestedNormalTypesList
{
    public int? Id { get; set; }

    public string? FullName { get; set; }

    public byte? Kind { get; set; }

    public bool? IsAbstract { get; set; }

    public bool? IsGeneric { get; set; }

    public bool? IsNested { get; set; }
}
