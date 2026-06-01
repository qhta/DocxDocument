
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the mail merge data source in a mail merge operation.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject?view=office-pia"/>
public partial class OfficeDataSourceObject
{
  /// <summary>
  /// Moves the focus to a specified row.
  /// </summary>
  /// <param name="MoveRow">The `MoveRow` parameter.</param>
  /// <param name="RowNbr">The `RowNbr` parameter.</param>
  /// <returns>The resulting row number.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.move?view=office-pia"/>
  public int Move(MoveRow MoveRow, int RowNbr) { throw new NotImplementedException(); }
  /// <summary>
  /// Opens a connection to a mail merge data source.
  /// </summary>
  /// <param name="bstrSrc">The `bstrSrc` parameter.</param>
  /// <param name="bstrConnect">The `bstrConnect` parameter.</param>
  /// <param name="bstrTable">The `bstrTable` parameter.</param>
  /// <param name="fOpenExclusive">The `fOpenExclusive` parameter.</param>
  /// <param name="fNeverPrompt">The `fNeverPrompt` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.open?view=office-pia"/>
  public void Open
    (string bstrSrc, string bstrConnect, string bstrTable, int fOpenExclusive, int fNeverPrompt)
  { throw new NotImplementedException(); }
  /// <summary>
  /// Sets the sort order for mail merge data.
  /// </summary>
  /// <param name="SortField1">The `SortField1` parameter.</param>
  /// <param name="SortAscending1">The `SortAscending1` parameter.</param>
  /// <param name="SortField2">The `SortField2` parameter.</param>
  /// <param name="SortAscending2">The `SortAscending2` parameter.</param>
  /// <param name="SortField3">The `SortField3` parameter.</param>
  /// <param name="SortAscending3">The `SortAscending3` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.setsortorder?view=office-pia"/>
  public void SetSortOrder
  (string SortField1, bool SortAscending1, string SortField2, bool SortAscending2,
    string SortField3, bool SortAscending3) { throw new NotImplementedException(); }
  /// <summary>
  /// Applies the configured filters to the data source.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.applyfilter?view=office-pia"/>
  public void ApplyFilter() { throw new NotImplementedException(); }
}

