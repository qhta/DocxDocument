using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface Shapes: InteropDictionary<string, Shape>
{
  public Shape Background { get; }
  public Shape Default { get; }
}
