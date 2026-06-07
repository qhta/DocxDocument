namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is inserted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinsertedtextmark?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdInsertedTextMark")]
public enum InsertedTextMark
{
  /// <summary>
  /// Inserted text is not marked up.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkNone")]
  None = 0,
  /// <summary>
  /// Inserted text is displayed in bold.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkBold")]
  Bold = 1,
  /// <summary>
  /// Inserted text is displayed in italics.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkItalic")]
  Italic = 2,
  /// <summary>
  /// Inserted text is underlined.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkUnderline")]
  Underline = 3,
  /// <summary>
  /// Inserted text is marked up by using double-underline characters.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkDoubleUnderline")]
  DoubleUnderline = 4,
  /// <summary>
  /// Inserted text is displayed in a specified color.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkColorOnly")]
  ColorOnly = 5,
  /// <summary>
  /// Inserted text is marked up by using strikethrough characters.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkStrikeThrough")]
  StrikeThrough = 6,
  /// <summary>
  /// Inserted text is marked up by using double- strikethrough characters.
  /// </summary>
  [InteropEnumValue("wdInsertedTextMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 7
}
