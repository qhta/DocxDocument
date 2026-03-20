using System.Collections;

namespace DocumentModel.Interop.Core;

public interface DocumentProperties: IEnumerable
{
  DocumentProperty this[object Index] { get; }
  int Count { get; }
  DocumentProperty Add(string Name, bool LinkToContent, object Type, object Value, object LinkSource);
  new IEnumerator GetEnumerator();
}