using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface ScopeFolder: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string Name { get; }
  string Path { get; }
  ScopeFolders ScopeFolders { get; }
  void AddToSearchFolders();
}