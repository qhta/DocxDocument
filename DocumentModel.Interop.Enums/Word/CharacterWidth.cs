namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character width of the specified range.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcharacterwidth?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdCharacterWidth))]
public enum CharacterWidth
{
  /// <summary>
  /// Characters are displayed in half the character width.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterWidth.wdWidthHalfWidth))]
  HalfWidth = 6,
  /// <summary>
  /// Characters are displayed in full character width.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdCharacterWidth.wdWidthFullWidth))]
  FullWidth = 7
}
