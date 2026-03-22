namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
/// </summary>
public enum WdMoveFromTextMark
{
  /// <summary>
  /// Hides moved text. wdMoveFromTextMarkDoubleStrikeThrough1 Marks moved text with a double strikethrough.
  /// </summary>
  wdMoveFromTextMarkHidden = unchecked((int)0),
  /// <summary>
  /// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  wdMoveFromTextMarkDoubleStrikeThrough = unchecked((int)1),
  /// <summary>
  /// Marks moved text with a strikethrough.
  /// </summary>
  wdMoveFromTextMarkStrikeThrough = unchecked((int)2),
  /// <summary>
  /// Marks moved text with a caret.
  /// </summary>
  wdMoveFromTextMarkCaret = unchecked((int)3),
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  wdMoveFromTextMarkPound = unchecked((int)4),
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  wdMoveFromTextMarkNone = unchecked((int)5),
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  wdMoveFromTextMarkBold = unchecked((int)6),
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  wdMoveFromTextMarkItalic = unchecked((int)7),
  /// <summary>
  /// Underlines moved text. wdMoveFromTextMarkDoubleUnderline9 Marks moved text with a double underline.
  /// [System.Runtime.InteropServices.Guid("AF2FC7DB-2E3E-3BF2-B1D0-6426945B15E0")] public enum WdMoveFromTextMark ﾉ
  /// Expand table
  /// </summary>
  wdMoveFromTextMarkUnderline = unchecked((int)8),
  /// <summary>
  /// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  wdMoveFromTextMarkDoubleUnderline = unchecked((int)9),
  /// <summary>
  /// Marks moved text with color only. Use the MoveFromTextColor property to set the color of moved text.
  /// </summary>
  wdMoveFromTextMarkColorOnly = unchecked((int)10)
}
