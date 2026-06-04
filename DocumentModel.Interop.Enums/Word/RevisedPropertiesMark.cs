namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revisions are displayed when change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisedpropertiesmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdRevisedPropertiesMark")]
public enum RevisedPropertiesMark
{
  /// <summary>
  /// Using a special character.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkNone")]
  None = 0,
  /// <summary>
  /// In bold.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkBold")]
  Bold = 1,
  /// <summary>
  /// In italics.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkItalic")]
  Italic = 2,
  /// <summary>
  /// With underline characters.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkUnderline")]
  Underline = 3,
  /// <summary>
  /// With double underline characters.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkDoubleUnderline")]
  DoubleUnderline = 4,
  /// <summary>
  /// In the designated color.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkColorOnly")]
  ColorOnly = 5,
  /// <summary>
  /// Using strikethrough characters.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkStrikeThrough")]
  StrikeThrough = 6,
  /// <summary>
  /// Using double-strikethrough characters.
  /// </summary>
  [WordInteropEnumValue("wdRevisedPropertiesMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 7
}
