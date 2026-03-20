using System.Collections;

namespace DocumentModel.Interop.Core;

public interface FoundFiles: InteropObject, IEnumerable
{
  string this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}