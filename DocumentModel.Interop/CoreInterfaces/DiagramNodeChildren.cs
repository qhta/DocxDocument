using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DiagramNodeChildren: InteropDictionary<string, DiagramNode>
{
  public DiagramNode FirstChild { get; }
  public DiagramNode LastChild { get; }
}
