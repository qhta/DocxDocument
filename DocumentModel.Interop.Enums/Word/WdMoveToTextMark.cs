namespace DocumentModel.Interop.Word;

/// <summary>
/// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmovetotextmark?view=office-pia` for Office interop details.
/// </remarks>
public enum WdMoveToTextMark
{
  /// <summary>
  /// No special formatting for moved text.
  /// </summary>
  None = 0,
  /// <summary>
  /// Marks moved text with bold formatting.
  /// </summary>
  Bold = 1,
  /// <summary>
  /// Marks moved text with italic formatting.
  /// </summary>
  Italic = 2,
  /// <summary>
  /// Underlines moved text. wdMoveToTextMarkDoubleUnderline4 Moved text is marked with a double underline.
  /// </summary>
  Underline = 3,
  /// <summary>
  /// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  DoubleUnderline = 4,
  /// <summary>
  /// Marks moved text with color only. Use the MoveToTextColor property to set the color of moved text.
  /// </summary>
  ColorOnly = 5,
  /// <summary>
  /// Moved text is marked with a strikethrough. wdMoveToTextMarkDoubleStrikeThrough7 Moved text is marked with a
  /// double strikethrough. [System.Runtime.InteropServices.Guid("F3AE6A1B-BB9F-3258-AAB9-87D6BAF4C3A3")] public
  /// enum WdMoveToTextMark ﾉ Expand table
  /// </summary>
  StrikeThrough = 6,
  /// <summary>
  /// Marks the moved-to text when text in a document with tracked changes is moved from one place to another.
  /// </summary>
  DoubleStrikeThrough = 7
}
