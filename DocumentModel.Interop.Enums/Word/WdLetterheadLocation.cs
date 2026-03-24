namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies a location to place letterhead in a letter created by the Letter Wizard.
/// </summary>
public enum WdLetterheadLocation
{
  /// <summary>
  /// At the top of the letter.
  /// </summary>
  Top = unchecked((int)0),
  /// <summary>
  /// At the bottom of the letter.
  /// </summary>
  Bottom = unchecked((int)1),
  /// <summary>
  /// To the left of the letter.
  /// </summary>
  Left = unchecked((int)2),
  /// <summary>
  /// To the right of the letter.
  /// </summary>
  Right = unchecked((int)3)
}
