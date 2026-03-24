namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is inserted while change tracking is enabled.
/// </summary>
public enum WdInsertedTextMark
{
  /// <summary>
  /// Inserted text is not marked up.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// Inserted text is displayed in bold.
  /// </summary>
  Bold = unchecked((int)1),
  /// <summary>
  /// Inserted text is displayed in italics.
  /// </summary>
  Italic = unchecked((int)2),
  /// <summary>
  /// Inserted text is underlined. wdInsertedTextMarkDoubleUnderline4 Inserted text is marked up by using
  /// double-underline characters.
  /// </summary>
  Underline = unchecked((int)3),
  /// <summary>
  /// Specifies the format of text that is inserted while change tracking is enabled.
  /// </summary>
  DoubleUnderline = unchecked((int)4),
  /// <summary>
  /// Inserted text is displayed in a specified color.
  /// </summary>
  ColorOnly = unchecked((int)5),
  /// <summary>
  /// Inserted text is marked up by using strikethrough characters. wdInsertedTextMarkDoubleStrikeThrough7 Inserted
  /// text is marked up by using double- strikethrough characters.
  /// [System.Runtime.InteropServices.Guid("1A98AA4F-A0F3-3980-9A55-0B958B6C8158")] public enum WdInsertedTextMark ﾉ
  /// Expand table
  /// </summary>
  StrikeThrough = unchecked((int)6),
  /// <summary>
  /// Specifies the format of text that is inserted while change tracking is enabled.
  /// </summary>
  DoubleStrikeThrough = unchecked((int)7)
}
