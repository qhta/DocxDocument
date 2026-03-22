namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the layout of a letter created by the Letter Wizard.
/// </summary>
public enum WdLetterStyle
{
  /// <summary>
  /// Full block.
  /// </summary>
  wdFullBlock = unchecked((int)0),
  /// <summary>
  /// Modified block.
  /// </summary>
  wdModifiedBlock = unchecked((int)1),
  /// <summary>
  /// Semi-block.
  /// </summary>
  wdSemiBlock = unchecked((int)2)
}
