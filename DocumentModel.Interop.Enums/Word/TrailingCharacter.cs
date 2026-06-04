namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the character inserted after the number for a numbered list item.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdtrailingcharacter?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdTrailingCharacter")]
public enum TrailingCharacter
{
  /// <summary>
  /// A tab is inserted.
  /// </summary>
  [WordInteropEnumValue("wdTrailingTab")]
  Tab = 0,
  /// <summary>
  /// A space is inserted. default.
  /// </summary>
  [WordInteropEnumValue("wdTrailingSpace")]
  Space = 1,
  /// <summary>
  /// No character is inserted.
  /// </summary>
  [WordInteropEnumValue("wdTrailingNone")]
  None = 2
}
