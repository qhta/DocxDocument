using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DiagramNodes
{
  public DiagramNode Item(object Index);
  public void SelectAll();
}
