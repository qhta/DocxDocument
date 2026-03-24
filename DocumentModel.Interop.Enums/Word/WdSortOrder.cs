namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort direction.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsortorder?view=office-pia` for Office interop details.
/// </remarks>
public enum WdSortOrder
{
  /// <summary>
  /// Ascending order. default.
  /// </summary>
  Ascending = 0,
  /// <summary>
  /// Descending order.
  /// </summary>
  Descending = 1
}
