namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort type to apply when sorting a column.
/// </summary>
public enum WdSortFieldType
{
  /// <summary>
  /// Alphanumeric order.
  /// </summary>
  wdSortFieldAlphanumeric = unchecked((int)0),
  /// <summary>
  /// Numeric order.
  /// </summary>
  wdSortFieldNumeric = unchecked((int)1),
  /// <summary>
  /// Date order.
  /// </summary>
  wdSortFieldDate = unchecked((int)2),
  /// <summary>
  /// Syllable order.
  /// </summary>
  wdSortFieldSyllable = unchecked((int)3),
  /// <summary>
  /// Japanese JIS order.
  /// </summary>
  wdSortFieldJapanJIS = unchecked((int)4),
  /// <summary>
  /// Stroke order.
  /// </summary>
  wdSortFieldStroke = unchecked((int)5),
  /// <summary>
  /// Korean KS order.
  /// </summary>
  wdSortFieldKoreaKS = unchecked((int)6)
}
