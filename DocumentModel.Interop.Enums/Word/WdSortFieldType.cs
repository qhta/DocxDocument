namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the sort type to apply when sorting a column.
/// </summary>
public enum WdSortFieldType
{
  /// <summary>
  /// Alphanumeric order.
  /// </summary>
  Alphanumeric = unchecked((int)0),
  /// <summary>
  /// Numeric order.
  /// </summary>
  Numeric = unchecked((int)1),
  /// <summary>
  /// Date order.
  /// </summary>
  Date = unchecked((int)2),
  /// <summary>
  /// Syllable order.
  /// </summary>
  Syllable = unchecked((int)3),
  /// <summary>
  /// Japanese JIS order.
  /// </summary>
  JapanJIS = unchecked((int)4),
  /// <summary>
  /// Stroke order.
  /// </summary>
  Stroke = unchecked((int)5),
  /// <summary>
  /// Korean KS order.
  /// </summary>
  KoreaKS = unchecked((int)6)
}
