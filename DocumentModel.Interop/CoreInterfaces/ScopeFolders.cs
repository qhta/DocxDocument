using System.Collections;

namespace DocumentModel.Interop.Core;

public interface ScopeFolders: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  ScopeFolder this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}