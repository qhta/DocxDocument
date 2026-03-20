using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface TabStops2: InteropDictionary<string, TabStop2>
{
  TabStop2 Item(object Index);
  TabStop2 Add(MsoTabStopType Type, float Position);
  float DefaultSpacing { get; set; }
}