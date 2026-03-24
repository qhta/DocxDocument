namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revisions are displayed when change tracking is enabled.
/// </summary>
public enum WdRevisedPropertiesMark
{
  /// <summary>
  /// Using a special character.
  /// </summary>
  None = unchecked((int)0),
  /// <summary>
  /// In bold.
  /// </summary>
  Bold = unchecked((int)1),
  /// <summary>
  /// In italics.
  /// </summary>
  Italic = unchecked((int)2),
  /// <summary>
  /// With underline characters. wdRevisedPropertiesMarkDoubleUnderline4 With double underline characters.
  /// </summary>
  Underline = unchecked((int)3),
  /// <summary>
  /// Specifies how revisions are displayed when change tracking is enabled.
  /// </summary>
  DoubleUnderline = unchecked((int)4),
  /// <summary>
  /// In the designated color.
  /// </summary>
  ColorOnly = unchecked((int)5),
  /// <summary>
  /// Using strikethrough characters.
  /// </summary>
  StrikeThrough = unchecked((int)6),
  /// <summary>
  /// Using double-strikethrough characters.
  /// </summary>
  DoubleStrikeThrough = unchecked((int)7)
}
