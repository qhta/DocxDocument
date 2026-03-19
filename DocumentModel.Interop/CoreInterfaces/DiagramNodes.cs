using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  DiagramNode Item(object Index);
  void SelectAll();
  object Parent { get; }
  int Count { get; }
}