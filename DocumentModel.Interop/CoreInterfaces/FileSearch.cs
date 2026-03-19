
namespace DocumentModel.Interop.Core;

public interface FileSearch: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  bool SearchSubFolders { get; set; }
  bool MatchTextExactly { get; set; }
  bool MatchAllWordForms { get; set; }
  string FileName { get; set; }
  MsoFileType FileType { get; set; }
  MsoLastModified LastModified { get; set; }
  string TextOrProperty { get; set; }
  string LookIn { get; set; }

  int Execute
  (MsoSortBy SortBy, MsoSortOrder SortOrder,
    bool AlwaysAccurate);

  void NewSearch();
  FoundFiles FoundFiles { get; }
  PropertyTests PropertyTests { get; }
  SearchScopes SearchScopes { get; }
  SearchFolders SearchFolders { get; }
  FileTypes FileTypes { get; }
  void RefreshScopes();
}