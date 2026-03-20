using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface DocumentInspector: InteropObject
{
  public string Name { get; }
  public string Description { get; }
}
