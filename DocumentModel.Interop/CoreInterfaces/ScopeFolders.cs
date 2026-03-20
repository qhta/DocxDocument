using System.Collections;

namespace DocumentModel.Interop.Core;

public interface ScopeFolders: InteropObject, IEnumerable
{
  ScopeFolder this[int Index] { get; }
  int Count { get; }
  new IEnumerator GetEnumerator();
}