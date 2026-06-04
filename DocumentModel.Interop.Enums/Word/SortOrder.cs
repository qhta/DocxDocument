namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort direction.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortorder?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSortOrder")]
public enum SortOrder
{
  /// <summary>
  /// Ascending order. default.
  /// </summary>
  [InteropEnumValue("wdSortOrderAscending")]
  Ascending = 0,
  /// <summary>
  /// Descending order.
  /// </summary>
  [InteropEnumValue("wdSortOrderDescending")]
  Descending = 1
}
