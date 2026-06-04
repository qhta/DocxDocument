namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the layout of a letter created by the Letter Wizard.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdletterstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdLetterStyle")]
public enum LetterStyle
{
  /// <summary>
  /// Full block.
  /// </summary>
  [InteropEnumValue("wdFullBlock")]
  FullBlock = 0,
  /// <summary>
  /// Modified block.
  /// </summary>
  [InteropEnumValue("wdModifiedBlock")]
  ModifiedBlock = 1,
  /// <summary>
  /// Semi-block.
  /// </summary>
  [InteropEnumValue("wdSemiBlock")]
  SemiBlock = 2
}
