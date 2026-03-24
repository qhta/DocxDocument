namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revisions are displayed when change tracking is enabled.
/// </summary>
public enum WdRevisedPropertiesMark
{
  /// <summary>
  /// Using a special character.
  /// </summary>
  None = 0,
  /// <summary>
  /// In bold.
  /// </summary>
  Bold = 1,
  /// <summary>
  /// In italics.
  /// </summary>
  Italic = 2,
  /// <summary>
  /// With underline characters. wdRevisedPropertiesMarkDoubleUnderline4 With double underline characters.
  /// </summary>
  Underline = 3,
  /// <summary>
  /// Specifies how revisions are displayed when change tracking is enabled.
  /// </summary>
  DoubleUnderline = 4,
  /// <summary>
  /// In the designated color.
  /// </summary>
  ColorOnly = 5,
  /// <summary>
  /// Using strikethrough characters.
  /// </summary>
  StrikeThrough = 6,
  /// <summary>
  /// Using double-strikethrough characters.
  /// </summary>
  DoubleStrikeThrough = 7
}
