using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodeChildren: InteropDictionary<string, DiagramNode>
{
  public DiagramNode Item(object Index);
  public DiagramNode AddNode(object Index, MsoDiagramNodeType NodeType);
  public void SelectAll();
  public DiagramNode FirstChild { get; }
  public DiagramNode LastChild { get; }
}
