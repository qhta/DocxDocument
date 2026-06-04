namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is inserted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinsertedtextmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdInsertedTextMark")]
public enum InsertedTextMark
{
  /// <summary>
  /// Inserted text is not marked up.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkNone")]
  None = 0,
  /// <summary>
  /// Inserted text is displayed in bold.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkBold")]
  Bold = 1,
  /// <summary>
  /// Inserted text is displayed in italics.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkItalic")]
  Italic = 2,
  /// <summary>
  /// Inserted text is underlined.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkUnderline")]
  Underline = 3,
  /// <summary>
  /// Inserted text is marked up by using double-underline characters.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkDoubleUnderline")]
  DoubleUnderline = 4,
  /// <summary>
  /// Inserted text is displayed in a specified color.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkColorOnly")]
  ColorOnly = 5,
  /// <summary>
  /// Inserted text is marked up by using strikethrough characters.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkStrikeThrough")]
  StrikeThrough = 6,
  /// <summary>
  /// Inserted text is marked up by using double- strikethrough characters.
  /// </summary>
  [WordInteropEnumValue("wdInsertedTextMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 7
}
