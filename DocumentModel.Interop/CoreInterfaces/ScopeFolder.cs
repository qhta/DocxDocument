using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ScopeFolder: InteropObject
{
  string Name { get; }
  string Path { get; }
  ScopeFolders ScopeFolders { get; }
  void AddToSearchFolders();
}