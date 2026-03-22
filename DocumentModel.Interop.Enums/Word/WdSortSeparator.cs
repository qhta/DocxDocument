namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field separator.
/// </summary>
public enum WdSortSeparator
{
  /// <summary>
  /// Tab.
  /// </summary>
  wdSortSeparateByTabs = unchecked((int)0),
  /// <summary>
  /// Comma.
  /// </summary>
  wdSortSeparateByCommas = unchecked((int)1),
  /// <summary>
  /// Default table separator.
  /// </summary>
  wdSortSeparateByDefaultTableSeparator = unchecked((int)2)
}
