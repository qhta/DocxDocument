using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodes: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  DiagramNode Item(object Index);
  void SelectAll();
  int Count { get; }
}