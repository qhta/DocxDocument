using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SearchScopes: InteropObject, IEnumerable
{
  SearchScope this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}