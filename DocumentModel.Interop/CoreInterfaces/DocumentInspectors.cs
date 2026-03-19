using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentInspectors: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  new IEnumerator GetEnumerator();
  DocumentInspector this[int Index] { get; }
  int Count { get; }
  object Parent { get; }
}