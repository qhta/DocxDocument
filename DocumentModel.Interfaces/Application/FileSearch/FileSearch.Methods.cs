
using DocumentModel.Wordprocessing;

namespace DocumentModel.Application;

/// <summary>
/// Represents file search functionality available in Office.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filesearch?view=office-pia"/>
public partial interface IFileSearch: IModelObject
{
  /// <summary>
  /// Executes the file search using the specified sort options.
  /// </summary>
  /// <param name="SortBy">The `SortBy` parameter.</param>
  /// <param name="SortOrder">The `SortOrder` parameter.</param>
  /// <param name="AlwaysAccurate">The `AlwaysAccurate` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filesearch.execute?view=office-pia"/>
  public int Execute
  (SortBy SortBy, SortOrder SortOrder,
    bool AlwaysAccurate);
  /// <summary>
  /// Starts a new file search.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filesearch.newsearch?view=office-pia"/>
  public void NewSearch();
  /// <summary>
  /// Refreshes the available search scopes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.filesearch.refreshscopes?view=office-pia"/>
  public void RefreshScopes();
}

