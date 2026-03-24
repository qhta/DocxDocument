namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of vertical alignment to apply.
/// </summary>
public enum WdVerticalAlignment
{
  /// <summary>
  /// Top vertical alignment.
  /// </summary>
  Top = unchecked((int)0),
  /// <summary>
  /// Center vertical alignment.
  /// </summary>
  Center = unchecked((int)1),
  /// <summary>
  /// Justified vertical alignment.
  /// </summary>
  Justify = unchecked((int)2),
  /// <summary>
  /// Bottom vertical alignment.
  /// </summary>
  Bottom = unchecked((int)3)
}
