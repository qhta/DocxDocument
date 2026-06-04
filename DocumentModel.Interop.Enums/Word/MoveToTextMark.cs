namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmovetotextmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdMoveToTextMark))]
public enum MoveToTextMark
{
  /// <summary>
  /// No special formatting for moved text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkNone))]
  None = 0,
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkBold))]
  Bold = 1,
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkItalic))]
  Italic = 2,
  /// <summary>
  /// Underlines moved text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkUnderline))]
  Underline = 3,
  /// <summary>
  /// Moved text is marked with a double underline.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkDoubleUnderline))]
  DoubleUnderline = 4,
  /// <summary>
  /// Marks moved text with color only. Use the MoveToTextColor property to set the color of moved text.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkColorOnly))]
  ColorOnly = 5,
  /// <summary>
  /// Moved text is marked with a strikethrough.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkStrikeThrough))]
  StrikeThrough = 6,
  /// <summary>
  /// Moved text is marked with a double strikethrough.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdMoveToTextMark.wdMoveToTextMarkDoubleStrikeThrough))]
  DoubleStrikeThrough = 7
}
