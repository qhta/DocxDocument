using System.Collections;

namespace DocumentModel.Interop.Core;

public interface WorkflowTemplates: _IMsoDispObj, IEnumerable
{
  new object Application
  {
    get;
  }

  new int Creator
  {
    get;
  }

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