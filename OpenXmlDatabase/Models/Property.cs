using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Property
{
    public int? Id { get; set; }

    public string? Name { get; set; }

    public int? ParentTypeId { get; set; }

    public virtual Type? ParentType { get; set; }
}
