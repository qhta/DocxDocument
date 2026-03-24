namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmovefromtextmark?view=office-pia` for Office interop details.
/// </remarks>
public enum WdMoveFromTextMark
{
  /// <summary>
  /// Hides moved text. wdMoveFromTextMarkDoubleStrikeThrough1 Marks moved text with a double strikethrough.
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  DoubleStrikeThrough = 1,
  /// <summary>
  /// Marks moved text with a strikethrough.
  /// </summary>
  StrikeThrough = 2,
  /// <summary>
  /// Marks moved text with a caret.
  /// </summary>
  Caret = 3,
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  Pound = 4,
  /// <summary>
  /// Marks moved text with a pound (number) sign.
  /// </summary>
  None = 5,
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  Bold = 6,
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  Italic = 7,
  /// <summary>
  /// Underlines moved text. wdMoveFromTextMarkDoubleUnderline9 Marks moved text with a double underline.
  /// [System.Runtime.InteropServices.Guid("AF2FC7DB-2E3E-3BF2-B1D0-6426945B15E0")] public enum WdMoveFromTextMark ﾉ
  /// Expand table
  /// </summary>
  Underline = 8,
  /// <summary>
  /// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  DoubleUnderline = 9,
  /// <summary>
  /// Marks moved text with color only. Use the MoveFromTextColor property to set the color of moved text.
  /// </summary>
  ColorOnly = 10
}
