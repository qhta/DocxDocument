using System.Collections;

namespace DocumentModel.Interop.Core;

public interface WorkflowTemplates: InteropObject, IEnumerable
{
  WorkflowTemplate this[int Index]
  {
    get;
  }

  int Count
  {
    get;
  }

  new IEnumerator GetEnumerator();
}