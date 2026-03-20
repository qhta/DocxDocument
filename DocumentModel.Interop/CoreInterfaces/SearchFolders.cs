using System.Collections;

namespace DocumentModel.Interop.Core;

public interface SearchFolders: InteropCollection<ScopeFolder>
{
  public void Add(ScopeFolder ScopeFolder);
  public void Remove(int Index);
}
