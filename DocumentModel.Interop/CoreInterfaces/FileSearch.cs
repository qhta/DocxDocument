
namespace DocumentModel.Interop.Core;

public interface FileSearch: InteropObject
{
  public bool SearchSubFolders { get; set; }
  public bool MatchTextExactly { get; set; }
  public bool MatchAllWordForms { get; set; }
  public string FileName { get; set; }
  public MsoFileType FileType { get; set; }
  public MsoLastModified LastModified { get; set; }
  public string TextOrProperty { get; set; }
  public string LookIn { get; set; }

  public int Execute
  (MsoSortBy SortBy, MsoSortOrder SortOrder,
    bool AlwaysAccurate);

  public void NewSearch();
  public FoundFiles FoundFiles { get; }
  public PropertyTests PropertyTests { get; }
  public SearchScopes SearchScopes { get; }
  public SearchFolders SearchFolders { get; }
  public FileTypes FileTypes { get; }
  public void RefreshScopes();
}
