using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodeChildren: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  DiagramNode Item(object Index);
  DiagramNode AddNode(object Index, MsoDiagramNodeType NodeType);
  void SelectAll();
  int Count { get; }
  DiagramNode FirstChild { get; }
  DiagramNode LastChild { get; }
}