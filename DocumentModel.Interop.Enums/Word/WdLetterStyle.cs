namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the layout of a letter created by the Letter Wizard.
/// </summary>
public enum WdLetterStyle
{
  /// <summary>
  /// Full block.
  /// </summary>
  FullBlock = unchecked((int)0),
  /// <summary>
  /// Modified block.
  /// </summary>
  ModifiedBlock = unchecked((int)1),
  /// <summary>
  /// Semi-block.
  /// </summary>
  SemiBlock = unchecked((int)2)
}
