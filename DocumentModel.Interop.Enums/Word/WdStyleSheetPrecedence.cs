namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
/// Web document.
/// </summary>
public enum WdStyleSheetPrecedence
{
  /// <summary>
  /// Lowest precedence.
  /// </summary>
  wdStyleSheetPrecedenceLowest = unchecked((int)0),
  /// <summary>
  /// Highest precedence.
  /// </summary>
  wdStyleSheetPrecedenceHighest = unchecked((int)1),
  /// <summary>
  /// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
  /// Web document.
  /// </summary>
  wdStyleSheetPrecedenceLower = unchecked((int)-2),
  /// <summary>
  /// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
  /// Web document.
  /// </summary>
  wdStyleSheetPrecedenceHigher = unchecked((int)-1)
}
