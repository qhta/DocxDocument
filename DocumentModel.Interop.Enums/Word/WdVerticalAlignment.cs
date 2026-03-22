namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
public enum WdVerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  wdAlignVerticalTop = unchecked((int)0),
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  wdAlignVerticalCenter = unchecked((int)1),
  /// <summary>
  /// Justified vertical alignment.
  /// </summary>
  wdAlignVerticalJustify = unchecked((int)2),
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  wdAlignVerticalBottom = unchecked((int)3)
}
