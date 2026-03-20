using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DiagramNodeChildren
{
  public DiagramNode Item(object Index);
  public DiagramNode AddNode(object Index, MsoDiagramNodeType NodeType);
  public void SelectAll();
}
