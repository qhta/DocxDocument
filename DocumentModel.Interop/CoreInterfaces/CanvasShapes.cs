using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface CanvasShapes: InteropDictionary<string, Shape>
{
  public Shape Background { get; }
}
