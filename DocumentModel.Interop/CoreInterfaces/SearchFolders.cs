using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SearchFolders: InteropCollection<ScopeFolder>
{
  void Add(ScopeFolder ScopeFolder);
  void Remove(int Index);
}