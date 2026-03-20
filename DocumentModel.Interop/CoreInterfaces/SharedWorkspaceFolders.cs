using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceFolders: InteropCollection<SharedWorkspaceFolder>
{
  SharedWorkspaceFolder Add(string FolderName, object ParentFolder);
  bool ItemCountExceeded { get; }
}