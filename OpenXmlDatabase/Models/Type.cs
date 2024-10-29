using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Type
{
    public int? Id { get; set; }

    public int? NamespaceId { get; set; }

    public string? Name { get; set; }

    public byte? Kind { get; set; }

    public bool? IsAbstract { get; set; }

    public bool? IsGeneric { get; set; }

    public bool? IsNested { get; set; }

    public int? ParentTypeId { get; set; }

    public int? SuperTypeId { get; set; }

    public virtual Namespace? Namespace { get; set; }

    public virtual ICollection<Property> Properties { get; set; } = new List<Property>();
}
