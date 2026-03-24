namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
/// </summary>
public enum WdMoveToTextMark
{
  /// <summary>
  /// No special formatting for moved text.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  Bold = unchecked((int)1),
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  Italic = unchecked((int)2),
  /// <summary>
  /// Underlines moved text. wdMoveToTextMarkDoubleUnderline4 Moved text is marked with a double underline.
  /// </summary>
  Underline = unchecked((int)3),
  /// <summary>
  /// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  DoubleUnderline = unchecked((int)4),
  /// <summary>
  /// Marks moved text with color only. Use the MoveToTextColor property to set the color of moved text.
  /// </summary>
  ColorOnly = unchecked((int)5),
  /// <summary>
  /// Moved text is marked with a strikethrough. wdMoveToTextMarkDoubleStrikeThrough7 Moved text is marked with a
  /// double strikethrough. [System.Runtime.InteropServices.Guid("F3AE6A1B-BB9F-3258-AAB9-87D6BAF4C3A3")] public
  /// enum WdMoveToTextMark ﾉ Expand table
  /// </summary>
  StrikeThrough = unchecked((int)6),
  /// <summary>
  /// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  DoubleStrikeThrough = unchecked((int)7)
}
