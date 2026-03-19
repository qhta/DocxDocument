using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodeChildren: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  DiagramNode Item(object Index);
  DiagramNode AddNode(object Index, MsoDiagramNodeType NodeType);
  void SelectAll();
  object Parent { get; }
  int Count { get; }
  DiagramNode FirstChild { get; }
  DiagramNode LastChild { get; }
}