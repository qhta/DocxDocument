namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is deleted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletedtextmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdDeletedTextMark")]
public enum DeletedTextMark
{
  /// <summary>
  /// Deleted text is hidden.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkHidden")]
  Hidden = 0,
  /// <summary>
  /// Deleted text is marked up by using strikethrough characters.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkStrikeThrough")]
  StrikeThrough = 1,
  /// <summary>
  /// Deleted text is marked up by using caret characters.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkCaret")]
  Caret = 2,
  /// <summary>
  /// Deleted text is marked up by using pound characters.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkPound")]
  Pound = 3,
  /// <summary>
  /// Deleted text is not marked up.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkNone")]
  None = 4,
  /// <summary>
  /// Deleted text is displayed in bold.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkBold")]
  Bold = 5,
  /// <summary>
  /// Deleted text is displayed in italics.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkItalic")]
  Italic = 6,
  /// <summary>
  /// Deleted text is underlined.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkUnderline")]
  Underline = 7,
  /// <summary>
  /// Deleted text is marked up by using double-underline characters.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkDoubleUnderline")]
  DoubleUnderline = 8,
  /// <summary>
  /// Deleted text is displayed in a specified color (default
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkColorOnly")]
  ColorOnly = 9,
  /// <summary>
  /// Deleted text is marked up by using double- strikethrough characters.
  /// </summary>
  [WordInteropEnumValue("wdDeletedTextMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 10
}
