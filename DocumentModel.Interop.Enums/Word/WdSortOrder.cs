namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort direction.
/// </summary>
public enum WdSortOrder
{
  /// <summary>
  /// Ascending order. default.
  /// </summary>
  wdSortOrderAscending = unchecked((int)0),
  /// <summary>
  /// Descending order.
  /// </summary>
  wdSortOrderDescending = unchecked((int)1)
}
