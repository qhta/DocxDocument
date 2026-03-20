using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface DiagramNodes: InteropDictionary<string, DiagramNode>
{
  public DiagramNode Item(object Index);
  public void SelectAll();
}
