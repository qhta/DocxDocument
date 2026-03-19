using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolder: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  string FolderName { get; }
  void Delete(object DeleteEventIfFolderContainsFiles);
  object Parent { get; }
}