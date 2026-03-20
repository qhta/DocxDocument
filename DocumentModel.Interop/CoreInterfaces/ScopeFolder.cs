using System.Reflection;

namespace DocumentModel.Interop.Core;

public partial interface ScopeFolder: InteropObject
{
  public string Name { get; }
  public string Path { get; }
  public ScopeFolders ScopeFolders { get; }
}
