namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is deleted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletedtextmark?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdDeletedTextMark")]
public enum DeletedTextMark
{
  /// <summary>
  /// Deleted text is hidden.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkHidden")]
  Hidden = 0,
  /// <summary>
  /// Deleted text is marked up by using strikethrough characters.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkStrikeThrough")]
  StrikeThrough = 1,
  /// <summary>
  /// Deleted text is marked up by using caret characters.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkCaret")]
  Caret = 2,
  /// <summary>
  /// Deleted text is marked up by using pound characters.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkPound")]
  Pound = 3,
  /// <summary>
  /// Deleted text is not marked up.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkNone")]
  None = 4,
  /// <summary>
  /// Deleted text is displayed in bold.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkBold")]
  Bold = 5,
  /// <summary>
  /// Deleted text is displayed in italics.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkItalic")]
  Italic = 6,
  /// <summary>
  /// Deleted text is underlined.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkUnderline")]
  Underline = 7,
  /// <summary>
  /// Deleted text is marked up by using double-underline characters.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkDoubleUnderline")]
  DoubleUnderline = 8,
  /// <summary>
  /// Deleted text is displayed in a specified color (default
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkColorOnly")]
  ColorOnly = 9,
  /// <summary>
  /// Deleted text is marked up by using double- strikethrough characters.
  /// </summary>
  [InteropEnumValue("wdDeletedTextMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 10
}
