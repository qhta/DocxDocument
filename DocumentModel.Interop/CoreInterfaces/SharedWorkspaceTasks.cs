using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceTasks: InteropObject, IEnumerable
{
  SharedWorkspaceTask this[int Index] { get; }
  int Count { get; }

  SharedWorkspaceTask Add
    (string Title, object Status, object Priority, object Assignee, object Description, object DueDate);
  bool ItemCountExceeded { get; }
  new IEnumerator GetEnumerator();
}