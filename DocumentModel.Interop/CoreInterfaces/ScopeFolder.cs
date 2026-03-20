using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ScopeFolder: InteropObject
{
  public string Name { get; }
  public string Path { get; }
  public ScopeFolders ScopeFolders { get; }
  public void AddToSearchFolders();
}
