using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolder: InteropObject
{
  string FolderName { get; }
  void Delete(object DeleteEventIfFolderContainsFiles);
}