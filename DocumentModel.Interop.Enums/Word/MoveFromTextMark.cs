namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-from text when text in a document with tracked changes is moved from one place to another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmovefromtextmark?view=office-pia` for Office interop details.
/// </remarks>
public enum MoveFromTextMark
{
  /// <summary>
  /// Hides moved text.
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// Marks moved text with a double strikethrough.
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
  /// Underlines moved text.
  /// </summary>
  Underline = 8,
  /// <summary>
  /// Marks moved text with a double underline.
  /// </summary>
  DoubleUnderline = 9,
  /// <summary>
  /// Marks moved text with color only. Use the MoveFromTextColor property to set the color of moved text.
  /// </summary>
  ColorOnly = 10
}
