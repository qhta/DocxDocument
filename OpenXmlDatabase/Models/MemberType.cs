using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class MemberType
{
    public int? Id { get; set; }

    public int? ParentTypeId { get; set; }

    public int? MemberTypeId { get; set; }

    public int? MinOccurrence { get; set; }

    public int? MaxOccurrence { get; set; }
}
