using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodeChildren: InteropDictionary<string, DiagramNode>
{
  DiagramNode Item(object Index);
  DiagramNode AddNode(object Index, MsoDiagramNodeType NodeType);
  void SelectAll();
  DiagramNode FirstChild { get; }
  DiagramNode LastChild { get; }
}