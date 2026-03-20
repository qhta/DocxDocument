using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceTasks: InteropCollection<SharedWorkspaceTask>
{
  SharedWorkspaceTask Add
    (string Title, object Status, object Priority, object Assignee, object Description, object DueDate);
  bool ItemCountExceeded { get; }
}