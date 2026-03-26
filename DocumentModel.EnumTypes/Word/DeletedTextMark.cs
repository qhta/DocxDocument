namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is deleted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletedtextmark?view=office-pia` for Office interop details.
/// </remarks>
public enum DeletedTextMark
{
  /// <summary>
  /// Deleted text is hidden.
  /// </summary>
  Hidden = 0,
  /// <summary>
  /// Deleted text is marked up by using strikethrough characters.
  /// </summary>
  StrikeThrough = 1,
  /// <summary>
  /// Deleted text is marked up by using caret characters.
  /// </summary>
  Caret = 2,
  /// <summary>
  /// Deleted text is marked up by using pound characters.
  /// </summary>
  Pound = 3,
  /// <summary>
  /// Deleted text is not marked up.
  /// </summary>
  None = 4,
  /// <summary>
  /// Deleted text is displayed in bold.
  /// </summary>
  Bold = 5,
  /// <summary>
  /// Deleted text is displayed in italics.
  /// </summary>
  Italic = 6,
  /// <summary>
  /// Deleted text is underlined.
  /// </summary>
  Underline = 7,
  /// <summary>
  /// Deleted text is marked up by using double-underline characters.
  /// </summary>
  DoubleUnderline = 8,
  /// <summary>
  /// Deleted text is displayed in a specified color (default
  /// </summary>
  ColorOnly = 9,
  /// <summary>
  /// Deleted text is marked up by using double- strikethrough characters.
  /// </summary>
  DoubleStrikeThrough = 10
}
