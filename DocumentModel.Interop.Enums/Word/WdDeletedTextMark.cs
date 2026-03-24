namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the format of text that is deleted while change tracking is enabled.
/// </summary>
public enum WdDeletedTextMark
{
  /// <summary>
  /// Deleted text is hidden.
  /// </summary>
  Hidden = unchecked((int)0),
  /// <summary>
  /// Deleted text is marked up by using strikethrough characters.
  /// </summary>
  StrikeThrough = unchecked((int)1),
  /// <summary>
  /// Deleted text is marked up by using caret characters.
  /// </summary>
  Caret = unchecked((int)2),
  /// <summary>
  /// Deleted text is marked up by using pound characters.
  /// </summary>
  Pound = unchecked((int)3),
  /// <summary>
  /// Deleted text is not marked up.
  /// </summary>
  None = unchecked((int)4),
  /// <summary>
  /// Deleted text is displayed in bold.
  /// </summary>
  Bold = unchecked((int)5),
  /// <summary>
  /// Deleted text is displayed in italics.
  /// </summary>
  Italic = unchecked((int)6),
  /// <summary>
  /// Deleted text is underlined. wdDeletedTextMarkDoubleUnderline8 Deleted text is marked up by using
  /// double-underline characters.
  /// </summary>
  Underline = unchecked((int)7),
  /// <summary>
  /// Specifies the format of text that is deleted while change tracking is enabled.
  /// </summary>
  DoubleUnderline = unchecked((int)8),
  /// <summary>
  /// Deleted text is displayed in a specified color (default
  /// [System.Runtime.InteropServices.Guid("002686EA-BC17-3B7C-BE4E-ECA572100016")] public enum WdDeletedTextMark ﾉ
  /// Expand table is red). wdDeletedTextMarkDoubleStrikeThrough10 Deleted text is marked up by using double-
  /// strikethrough characters.
  /// </summary>
  ColorOnly = unchecked((int)9),
  /// <summary>
  /// Specifies the format of text that is deleted while change tracking is enabled.
  /// </summary>
  DoubleStrikeThrough = unchecked((int)10)
}
