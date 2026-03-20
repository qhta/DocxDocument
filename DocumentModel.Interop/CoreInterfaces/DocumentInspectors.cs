using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentInspectors: InteropObject, IEnumerable
{
  new IEnumerator GetEnumerator();
  DocumentInspector this[int Index] { get; }
  int Count { get; }
}