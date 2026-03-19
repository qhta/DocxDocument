using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SearchScopes: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  SearchScope this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}