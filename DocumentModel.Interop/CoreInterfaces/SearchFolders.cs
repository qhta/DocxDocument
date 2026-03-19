using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SearchFolders: _IMsoDispObj, IEnumerable
{
  new object Application { get; }
  new int Creator { get; }
  ScopeFolder this[int Index] { get; }
  int Count { get; }
  void Add(ScopeFolder ScopeFolder);
  void Remove(int Index);
  new IEnumerator GetEnumerator();
}