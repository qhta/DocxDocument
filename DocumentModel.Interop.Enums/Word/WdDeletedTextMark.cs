namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is deleted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wddeletedtextmark?view=office-pia` for Office interop details.
/// </remarks>
public enum WdDeletedTextMark
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
  /// Deleted text is underlined. wdDeletedTextMarkDoubleUnderline8 Deleted text is marked up by using
  /// double-underline characters.
  /// </summary>
  Underline = 7,
  /// <summary>
  /// Specifies the format of text that is deleted while change tracking is enabled.
  /// </summary>
  DoubleUnderline = 8,
  /// <summary>
  /// Deleted text is displayed in a specified color (default
  /// [System.Runtime.InteropServices.Guid("002686EA-BC17-3B7C-BE4E-ECA572100016")] public enum WdDeletedTextMark ﾉ
  /// Expand table is red). wdDeletedTextMarkDoubleStrikeThrough10 Deleted text is marked up by using double-
  /// strikethrough characters.
  /// </summary>
  ColorOnly = 9,
  /// <summary>
  /// Specifies the format of text that is deleted while change tracking is enabled.
  /// </summary>
  DoubleStrikeThrough = 10
}
