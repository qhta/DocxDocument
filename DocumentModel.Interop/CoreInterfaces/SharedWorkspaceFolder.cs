using System.Reflection;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolder: InteropObject
{
  public string FolderName { get; }
  public void Delete(object DeleteEventIfFolderContainsFiles);
}
