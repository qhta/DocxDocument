using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFiles
{
  public SharedWorkspaceFile Add(string FileName, object ParentFolder, object OverwriteIfFileAlreadyExists, object KeepInSync);
}
