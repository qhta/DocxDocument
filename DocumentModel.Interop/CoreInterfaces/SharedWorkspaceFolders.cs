using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolders: InteropCollection<SharedWorkspaceFolder>
{
  public SharedWorkspaceFolder Add(string FolderName, object ParentFolder);
  public bool ItemCountExceeded { get; }
}
