namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is inserted while change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdinsertedtextmark?view=office-pia` for Office interop details.
/// </remarks>
public enum WdInsertedTextMark
{
  /// <summary>
  /// Inserted text is not marked up.
  /// </summary>
  None = 0,
  /// <summary>
  /// Inserted text is displayed in bold.
  /// </summary>
  Bold = 1,
  /// <summary>
  /// Inserted text is displayed in italics.
  /// </summary>
  Italic = 2,
  /// <summary>
  /// Inserted text is underlined. wdInsertedTextMarkDoubleUnderline4 Inserted text is marked up by using
  /// double-underline characters.
  /// </summary>
  Underline = 3,
  /// <summary>
  /// Specifies the format of text that is inserted while change tracking is enabled.
  /// </summary>
  DoubleUnderline = 4,
  /// <summary>
  /// Inserted text is displayed in a specified color.
  /// </summary>
  ColorOnly = 5,
  /// <summary>
  /// Inserted text is marked up by using strikethrough characters. wdInsertedTextMarkDoubleStrikeThrough7 Inserted
  /// text is marked up by using double- strikethrough characters.
  /// [System.Runtime.InteropServices.Guid("1A98AA4F-A0F3-3980-9A55-0B958B6C8158")] public enum WdInsertedTextMark ﾉ
  /// Expand table
  /// </summary>
  StrikeThrough = 6,
  /// <summary>
  /// Specifies the format of text that is inserted while change tracking is enabled.
  /// </summary>
  DoubleStrikeThrough = 7
}
