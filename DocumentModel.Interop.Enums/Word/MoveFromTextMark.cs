namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmovefromtextmark?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMoveFromTextMark")]
public enum MoveFromTextMark
{
  /// <summary>
  /// Hides moved text.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkHidden")]
  Hidden = 0,
  /// <summary>
  /// Marks moved text with a double strikethrough.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 1,
  /// <summary>
  /// Marks moved text with a strikethrough.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkStrikeThrough")]
  StrikeThrough = 2,
  /// <summary>
  /// Marks moved text with a caret.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkCaret")]
  Caret = 3,
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkPound")]
  Pound = 4,
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkNone")]
  None = 5,
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkBold")]
  Bold = 6,
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkItalic")]
  Italic = 7,
  /// <summary>
  /// Underlines moved text.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkUnderline")]
  Underline = 8,
  /// <summary>
  /// Marks moved text with a double underline.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkDoubleUnderline")]
  DoubleUnderline = 9,
  /// <summary>
  /// Marks moved text with color only. Use the MoveFromTextColor property to set the color of moved text.
  /// </summary>
  [InteropEnumValue("wdMoveFromTextMarkColorOnly")]
  ColorOnly = 10
}
