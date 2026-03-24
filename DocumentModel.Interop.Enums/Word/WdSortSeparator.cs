namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of field separator.
/// </summary>
public enum WdSortSeparator
{
  /// <summary>
  /// Tab.
  /// </summary>
  Tabs = unchecked((int)0),
  /// <summary>
  /// Comma.
  /// </summary>
  Commas = unchecked((int)1),
  /// <summary>
  /// Default table separator.
  /// </summary>
  DefaultTableSeparator = unchecked((int)2)
}
