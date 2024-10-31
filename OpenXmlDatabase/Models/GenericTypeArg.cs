using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class GenericTypeArg
{
    public int? Id { get; set; }

    public int? GenericTypeId { get; set; }

    public byte? ArgNo { get; set; }

    public int? ArgTypeId { get; set; }

    public virtual Type? GenericType { get; set; }
}
