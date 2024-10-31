using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Type
{
    public int? Id { get; set; }

    public int? NamespaceId { get; set; }

    public int? AssemblyId { get; set; }

    public string? Name { get; set; }

    public byte? Kind { get; set; }

    public bool? IsAbstract { get; set; }

    public bool? IsGeneric { get; set; }

    public bool? IsNested { get; set; }

    public int? ParentTypeId { get; set; }

    public int? SuperTypeId { get; set; }

    public string? Description { get; set; }

    public string? Tag { get; set; }

    public byte? OfficeVersion { get; set; }

    public virtual ICollection<GenericTypeArg> GenericTypeArgs { get; set; } = new List<GenericTypeArg>();

    public virtual Namespace? Namespace { get; set; }

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
