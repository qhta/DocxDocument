using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceTasks: InteropCollection<SharedWorkspaceTask>
{
  public bool ItemCountExceeded { get; }
}
