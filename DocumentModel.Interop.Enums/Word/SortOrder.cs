namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort direction.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortorder?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSortOrder")]
public enum SortOrder
{
  /// <summary>
  /// Ascending order. default.
  /// </summary>
  [WordInteropEnumValue("wdSortOrderAscending")]
  Ascending = 0,
  /// <summary>
  /// Descending order.
  /// </summary>
  [WordInteropEnumValue("wdSortOrderDescending")]
  Descending = 1
}
