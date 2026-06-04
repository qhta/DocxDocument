namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmovefromtextmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMoveFromTextMark")]
public enum MoveFromTextMark
{
  /// <summary>
  /// Hides moved text.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkHidden")]
  Hidden = 0,
  /// <summary>
  /// Marks moved text with a double strikethrough.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 1,
  /// <summary>
  /// Marks moved text with a strikethrough.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkStrikeThrough")]
  StrikeThrough = 2,
  /// <summary>
  /// Marks moved text with a caret.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkCaret")]
  Caret = 3,
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkPound")]
  Pound = 4,
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkNone")]
  None = 5,
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkBold")]
  Bold = 6,
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkItalic")]
  Italic = 7,
  /// <summary>
  /// Underlines moved text.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkUnderline")]
  Underline = 8,
  /// <summary>
  /// Marks moved text with a double underline.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkDoubleUnderline")]
  DoubleUnderline = 9,
  /// <summary>
  /// Marks moved text with color only. Use the MoveFromTextColor property to set the color of moved text.
  /// </summary>
  [WordInteropEnumValue("wdMoveFromTextMarkColorOnly")]
  ColorOnly = 10
}
