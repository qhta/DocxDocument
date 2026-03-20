
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `OfficeDataSourceObject` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject?view=office-pia` for Office interop details.
/// </remarks>
public partial interface OfficeDataSourceObject
{
  /// <summary>
  /// Invokes `Move`.
  /// </summary>
  /// <param name="MsoMoveRow">The `MsoMoveRow` parameter.</param>
  /// <param name="RowNbr">The `RowNbr` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.move?view=office-pia
  /// </remarks>
  public int Move(MsoMoveRow MsoMoveRow, int RowNbr);
  /// <summary>
  /// Invokes `Open`.
  /// </summary>
  /// <param name="bstrSrc">The `bstrSrc` parameter.</param>
  /// <param name="bstrConnect">The `bstrConnect` parameter.</param>
  /// <param name="bstrTable">The `bstrTable` parameter.</param>
  /// <param name="fOpenExclusive">The `fOpenExclusive` parameter.</param>
  /// <param name="fNeverPrompt">The `fNeverPrompt` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.open?view=office-pia
  /// </remarks>
  public void Open
    (string bstrSrc, string bstrConnect, string bstrTable, int fOpenExclusive, int fNeverPrompt);
  /// <summary>
  /// Invokes `SetSortOrder`.
  /// </summary>
  /// <param name="SortField1">The `SortField1` parameter.</param>
  /// <param name="SortAscending1">The `SortAscending1` parameter.</param>
  /// <param name="SortField2">The `SortField2` parameter.</param>
  /// <param name="SortAscending2">The `SortAscending2` parameter.</param>
  /// <param name="SortField3">The `SortField3` parameter.</param>
  /// <param name="SortAscending3">The `SortAscending3` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.setsortorder?view=office-pia
  /// </remarks>
  public void SetSortOrder
  (string SortField1, bool SortAscending1, string SortField2, bool SortAscending2,
    string SortField3, bool SortAscending3);
  /// <summary>
  /// Invokes `ApplyFilter`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.officedatasourceobject.applyfilter?view=office-pia
  /// </remarks>
  public void ApplyFilter();
}
