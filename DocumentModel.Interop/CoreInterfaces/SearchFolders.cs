using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SearchFolders: InteropObject, IEnumerable
{
  ScopeFolder this[int Index] { get; }
  int Count { get; }
  void Add(ScopeFolder ScopeFolder);
  void Remove(int Index);
  new IEnumerator GetEnumerator();
}