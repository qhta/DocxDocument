namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is inserted while change tracking is enabled.
/// </summary>
public enum WdInsertedTextMark
{
  /// <summary>
  /// Inserted text is not marked up.
  /// </summary>
  wdInsertedTextMarkNone = unchecked((int)0),
  /// <summary>
  /// Inserted text is displayed in bold.
  /// </summary>
  wdInsertedTextMarkBold = unchecked((int)1),
  /// <summary>
  /// Inserted text is displayed in italics.
  /// </summary>
  wdInsertedTextMarkItalic = unchecked((int)2),
  /// <summary>
  /// Inserted text is underlined. wdInsertedTextMarkDoubleUnderline4 Inserted text is marked up by using
  /// double-underline characters.
  /// </summary>
  wdInsertedTextMarkUnderline = unchecked((int)3),
  /// <summary>
  /// Specifies the format of text that is inserted while change tracking is enabled.
  /// </summary>
  wdInsertedTextMarkDoubleUnderline = unchecked((int)4),
  /// <summary>
  /// Inserted text is displayed in a specified color.
  /// </summary>
  wdInsertedTextMarkColorOnly = unchecked((int)5),
  /// <summary>
  /// Inserted text is marked up by using strikethrough characters. wdInsertedTextMarkDoubleStrikeThrough7 Inserted
  /// text is marked up by using double- strikethrough characters.
  /// [System.Runtime.InteropServices.Guid("1A98AA4F-A0F3-3980-9A55-0B958B6C8158")] public enum WdInsertedTextMark ﾉ
  /// Expand table
  /// </summary>
  wdInsertedTextMarkStrikeThrough = unchecked((int)6),
  /// <summary>
  /// Specifies the format of text that is inserted while change tracking is enabled.
  /// </summary>
  wdInsertedTextMarkDoubleStrikeThrough = unchecked((int)7)
}
