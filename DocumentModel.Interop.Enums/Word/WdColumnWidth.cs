namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent column width in reading layout, passed to and returned by the ColumnWidth property.
/// </summary>
public enum WdColumnWidth
{
  /// <summary>
  /// Narrow column width.
  /// </summary>
  wdColumnWidthNarrow = unchecked((int)1),
  /// <summary>
  /// Default column width.
  /// </summary>
  wdColumnWidthDefault = unchecked((int)2),
  /// <summary>
  /// Wide column width.
  /// </summary>
  wdColumnWidthWide = unchecked((int)3)
}
