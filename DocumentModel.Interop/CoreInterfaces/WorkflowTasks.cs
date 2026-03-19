using System.Collections;

namespace DocumentModel.Interop.Core;

public interface WorkflowTasks: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  WorkflowTask this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}