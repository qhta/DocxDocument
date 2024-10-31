using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Type
{
  public override string ToString()
  {
    return $"OpenXmlType({Name})";
  }
}
