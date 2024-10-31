using System;
using System.Collections.Generic;

namespace OpenXmlDatabase.Models;

public partial class Property
{
  public override string ToString()
  {
    return $"OpenXmlProperty({Name})";
  }
}
