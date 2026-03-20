using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceFiles: InteropCollection<SharedWorkspaceFile>
{
  public bool ItemCountExceeded { get; }
}
