namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of emphasis mark to use for a character or designated character string.
/// </summary>
public enum WdEmphasisMark
{
  /// <summary>
  /// No emphasis mark.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// A solid black circle.
  /// </summary>
  OverSolidCircle = unchecked((int)1),
  /// <summary>
  /// A comma.
  /// </summary>
  OverComma = unchecked((int)2),
  /// <summary>
  /// An empty white circle.
  /// </summary>
  OverWhiteCircle = unchecked((int)3),
  /// <summary>
  /// A solid black circle.
  /// </summary>
  UnderSolidCircle = unchecked((int)4)
}
