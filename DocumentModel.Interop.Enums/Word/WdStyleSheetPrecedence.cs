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
  Lowest = unchecked((int)0),
  /// <summary>
  /// Highest precedence.
  /// </summary>
  Highest = unchecked((int)1),
  /// <summary>
  /// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
  /// Web document.
  /// </summary>
  Lower = unchecked((int)-2),
  /// <summary>
  /// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
  /// Web document.
  /// </summary>
  Higher = unchecked((int)-1)
}
