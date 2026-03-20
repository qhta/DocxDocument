using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface TabStops2: InteropObject, IEnumerable
{
  TabStop2 Item(object Index);
  TabStop2 Add(MsoTabStopType Type, float Position);
  int Count { get; }
  float DefaultSpacing { get; set; }
  new IEnumerator GetEnumerator();
}