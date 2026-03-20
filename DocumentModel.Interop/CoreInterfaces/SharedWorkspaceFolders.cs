using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFolders: InteropCollection<SharedWorkspaceFolder>
{
  public bool ItemCountExceeded { get; }
}
