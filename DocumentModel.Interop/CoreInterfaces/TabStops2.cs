using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface TabStops2: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  TabStop2 Item(object Index);
  object Parent { get; }
  TabStop2 Add(MsoTabStopType Type, float Position);
  int Count { get; }
  float DefaultSpacing { get; set; }
  new IEnumerator GetEnumerator();
}