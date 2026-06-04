namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character inserted after the number for a numbered list item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtrailingcharacter?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdTrailingCharacter")]
public enum TrailingCharacter
{
  /// <summary>
  /// A tab is inserted.
  /// </summary>
  [InteropEnumValue("wdTrailingTab")]
  Tab = 0,
  /// <summary>
  /// A space is inserted. default.
  /// </summary>
  [InteropEnumValue("wdTrailingSpace")]
  Space = 1,
  /// <summary>
  /// No character is inserted.
  /// </summary>
  [InteropEnumValue("wdTrailingNone")]
  None = 2
}
