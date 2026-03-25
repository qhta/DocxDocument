namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the layout of a letter created by the Letter Wizard.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdletterstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum WdLetterStyle
{
  /// <summary>
  /// Full block.
  /// </summary>
  FullBlock = 0,
  /// <summary>
  /// Modified block.
  /// </summary>
  ModifiedBlock = 1,
  /// <summary>
  /// Semi-block.
  /// </summary>
  SemiBlock = 2
}
