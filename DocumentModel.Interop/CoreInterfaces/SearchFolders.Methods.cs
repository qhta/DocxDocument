using System.Collections;

namespace DocumentModel.Interop.Core;

public partial interface SearchFolders
{
  public void Add(ScopeFolder ScopeFolder);
  public void Remove(int Index);
}
