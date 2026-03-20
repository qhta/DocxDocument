using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFolders
{
  public SharedWorkspaceFolder Add(string FolderName, object ParentFolder);
}
