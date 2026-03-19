using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SharedWorkspaceTasks: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  SharedWorkspaceTask this[int Index] { get; }
  int Count { get; }

  SharedWorkspaceTask Add
    (string Title, object Status, object Priority, object Assignee, object Description, object DueDate);

  object Parent { get; }
  bool ItemCountExceeded { get; }
  new IEnumerator GetEnumerator();
}