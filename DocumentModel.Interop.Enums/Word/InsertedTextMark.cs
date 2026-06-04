namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is inserted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinsertedtextmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdInsertedTextMark))]
public enum InsertedTextMark
{
  /// <summary>
  /// Inserted text is not marked up.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkNone))]
  None = 0,
  /// <summary>
  /// Inserted text is displayed in bold.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkBold))]
  Bold = 1,
  /// <summary>
  /// Inserted text is displayed in italics.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkItalic))]
  Italic = 2,
  /// <summary>
  /// Inserted text is underlined.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkUnderline))]
  Underline = 3,
  /// <summary>
  /// Inserted text is marked up by using double-underline characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkDoubleUnderline))]
  DoubleUnderline = 4,
  /// <summary>
  /// Inserted text is displayed in a specified color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkColorOnly))]
  ColorOnly = 5,
  /// <summary>
  /// Inserted text is marked up by using strikethrough characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkStrikeThrough))]
  StrikeThrough = 6,
  /// <summary>
  /// Inserted text is marked up by using double- strikethrough characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdInsertedTextMark.wdInsertedTextMarkDoubleStrikeThrough))]
  DoubleStrikeThrough = 7
}
