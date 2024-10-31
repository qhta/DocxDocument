using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Property
{
    public int? Id { get; set; }

    public int? ParentTypeId { get; set; }

    public string? Name { get; set; }

    public int? ValueTypeId { get; set; }

    public bool? IsPublic { get; set; }

    public bool? IsStatic { get; set; }

    public bool? IsAbstract { get; set; }

    public bool? IsVirtual { get; set; }

    public bool? IsOverride { get; set; }

    public string? Description { get; set; }

    public string? Tag { get; set; }

    public byte? OfficeVersion { get; set; }

    public virtual Type? ParentType { get; set; }
}
