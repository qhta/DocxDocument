namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revisions are displayed when change tracking is enabled.
/// </summary>
public enum WdRevisedPropertiesMark
{
  /// <summary>
  /// Using a special character.
  /// </summary>
  wdRevisedPropertiesMarkNone = unchecked((int)0),
  /// <summary>
  /// In bold.
  /// </summary>
  wdRevisedPropertiesMarkBold = unchecked((int)1),
  /// <summary>
  /// In italics.
  /// </summary>
  wdRevisedPropertiesMarkItalic = unchecked((int)2),
  /// <summary>
  /// With underline characters. wdRevisedPropertiesMarkDoubleUnderline4 With double underline characters.
  /// </summary>
  wdRevisedPropertiesMarkUnderline = unchecked((int)3),
  /// <summary>
  /// Specifies how revisions are displayed when change tracking is enabled.
  /// </summary>
  wdRevisedPropertiesMarkDoubleUnderline = unchecked((int)4),
  /// <summary>
  /// In the designated color.
  /// </summary>
  wdRevisedPropertiesMarkColorOnly = unchecked((int)5),
  /// <summary>
  /// Using strikethrough characters.
  /// </summary>
  wdRevisedPropertiesMarkStrikeThrough = unchecked((int)6),
  /// <summary>
  /// Using double-strikethrough characters.
  /// </summary>
  wdRevisedPropertiesMarkDoubleStrikeThrough = unchecked((int)7)
}
