namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the layout of a letter created by the Letter Wizard.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdletterstyle?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdLetterStyle))]
public enum LetterStyle
{
  /// <summary>
  /// Full block.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterStyle.wdFullBlock))]
  FullBlock = 0,
  /// <summary>
  /// Modified block.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterStyle.wdModifiedBlock))]
  ModifiedBlock = 1,
  /// <summary>
  /// Semi-block.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdLetterStyle.wdSemiBlock))]
  SemiBlock = 2
}
