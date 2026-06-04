
namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies whether files in a FileSearch object's FoundFiles collection should be sorted in ascending or
/// descending order.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosortorder?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoSortOrder")]
public enum SortOrder
{
  /// <summary>
  /// Ascending order.
  /// </summary>
  [OfficeInteropEnumValue("msoSortOrderAscending")]
  Ascending = 1,
  /// <summary>
  /// Descending order.
  /// </summary>
  [OfficeInteropEnumValue("msoSortOrderDescending")]
  Descending
}
