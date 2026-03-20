using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceMembers: InteropCollection<SharedWorkspaceMember>
{
  public bool ItemCountExceeded { get; }
}
