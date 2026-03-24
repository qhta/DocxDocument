namespace DocumentModel.Interop.Word;

/// <summary>
/// Constants that represent column width in reading layout, passed to and returned by the ColumnWidth property.
/// </summary>
public enum WdColumnWidth
{
  /// <summary>
  /// Narrow column width.
  /// </summary>
  Narrow = unchecked((int)1),
  /// <summary>
  /// Default column width.
  /// </summary>
  Default = unchecked((int)2),
  /// <summary>
  /// Wide column width.
  /// </summary>
  Wide = unchecked((int)3)
}
