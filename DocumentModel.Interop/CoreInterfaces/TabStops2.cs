using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface TabStops2: InteropDictionary<string, TabStop2>
{
  public float DefaultSpacing { get; set; }
}
