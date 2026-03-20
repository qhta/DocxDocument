using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface TabStops2: InteropDictionary<string, TabStop2>
{
  public TabStop2 Item(object Index);
  public TabStop2 Add(MsoTabStopType Type, float Position);
  public float DefaultSpacing { get; set; }
}
