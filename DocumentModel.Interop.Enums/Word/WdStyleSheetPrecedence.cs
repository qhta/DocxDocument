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
  Lowest = 0,
  /// <summary>
  /// Highest precedence.
  /// </summary>
  Highest = 1,
  /// <summary>
  /// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
  /// Web document.
  /// </summary>
  Lower = -2,
  /// <summary>
  /// Specifies the level of importance of a style sheet compared to other cascading style sheets attached to the
  /// Web document.
  /// </summary>
  Higher = -1
}
