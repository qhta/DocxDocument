
namespace DocumentModel.Interop.Core;

public partial interface FileSearch
{
  public int Execute
  (MsoSortBy SortBy, MsoSortOrder SortOrder,
    bool AlwaysAccurate);
  public void NewSearch();
  public void RefreshScopes();
}
