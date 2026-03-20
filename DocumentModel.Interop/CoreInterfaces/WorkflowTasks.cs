using System.Collections;

namespace DocumentModel.Interop.Core;

public interface WorkflowTasks: InteropObject, IEnumerable
{
  WorkflowTask this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}