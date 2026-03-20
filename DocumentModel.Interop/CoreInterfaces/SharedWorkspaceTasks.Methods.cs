using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SharedWorkspaceTasks
{
  public SharedWorkspaceTask Add
    (string Title, object Status, object Priority, object Assignee, object Description, object DueDate);
}
