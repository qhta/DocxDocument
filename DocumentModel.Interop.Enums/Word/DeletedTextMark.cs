namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is deleted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletedtextmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdDeletedTextMark))]
public enum DeletedTextMark
{
  /// <summary>
  /// Deleted text is hidden.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkHidden))]
  Hidden = 0,
  /// <summary>
  /// Deleted text is marked up by using strikethrough characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkStrikeThrough))]
  StrikeThrough = 1,
  /// <summary>
  /// Deleted text is marked up by using caret characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkCaret))]
  Caret = 2,
  /// <summary>
  /// Deleted text is marked up by using pound characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkPound))]
  Pound = 3,
  /// <summary>
  /// Deleted text is not marked up.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkNone))]
  None = 4,
  /// <summary>
  /// Deleted text is displayed in bold.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkBold))]
  Bold = 5,
  /// <summary>
  /// Deleted text is displayed in italics.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkItalic))]
  Italic = 6,
  /// <summary>
  /// Deleted text is underlined.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkUnderline))]
  Underline = 7,
  /// <summary>
  /// Deleted text is marked up by using double-underline characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkDoubleUnderline))]
  DoubleUnderline = 8,
  /// <summary>
  /// Deleted text is displayed in a specified color (default
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkColorOnly))]
  ColorOnly = 9,
  /// <summary>
  /// Deleted text is marked up by using double- strikethrough characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdDeletedTextMark.wdDeletedTextMarkDoubleStrikeThrough))]
  DoubleStrikeThrough = 10
}
