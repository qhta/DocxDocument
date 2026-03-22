namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of emphasis mark to use for a character or designated character string.
/// </summary>
public enum WdEmphasisMark
{
  /// <summary>
  /// No emphasis mark.
  /// </summary>
  wdEmphasisMarkNone = unchecked((int)0),
  /// <summary>
  /// A solid black circle.
  /// </summary>
  wdEmphasisMarkOverSolidCircle = unchecked((int)1),
  /// <summary>
  /// A comma.
  /// </summary>
  wdEmphasisMarkOverComma = unchecked((int)2),
  /// <summary>
  /// An empty white circle.
  /// </summary>
  wdEmphasisMarkOverWhiteCircle = unchecked((int)3),
  /// <summary>
  /// A solid black circle.
  /// </summary>
  wdEmphasisMarkUnderSolidCircle = unchecked((int)4)
}
