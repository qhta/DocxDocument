namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the layout of a letter created by the Letter Wizard.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdletterstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdLetterStyle")]
public enum LetterStyle
{
  /// <summary>
  /// Full block.
  /// </summary>
  [WordInteropEnumValue("wdFullBlock")]
  FullBlock = 0,
  /// <summary>
  /// Modified block.
  /// </summary>
  [WordInteropEnumValue("wdModifiedBlock")]
  ModifiedBlock = 1,
  /// <summary>
  /// Semi-block.
  /// </summary>
  [WordInteropEnumValue("wdSemiBlock")]
  SemiBlock = 2
}
