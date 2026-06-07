namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revisions are displayed when change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisedpropertiesmark?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdRevisedPropertiesMark")]
public enum RevisedPropertiesMark
{
  /// <summary>
  /// Using a special character.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkNone")]
  None = 0,
  /// <summary>
  /// In bold.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkBold")]
  Bold = 1,
  /// <summary>
  /// In italics.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkItalic")]
  Italic = 2,
  /// <summary>
  /// With underline characters.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkUnderline")]
  Underline = 3,
  /// <summary>
  /// With double underline characters.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkDoubleUnderline")]
  DoubleUnderline = 4,
  /// <summary>
  /// In the designated color.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkColorOnly")]
  ColorOnly = 5,
  /// <summary>
  /// Using strikethrough characters.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkStrikeThrough")]
  StrikeThrough = 6,
  /// <summary>
  /// Using double-strikethrough characters.
  /// </summary>
  [InteropEnumValue("wdRevisedPropertiesMarkDoubleStrikeThrough")]
  DoubleStrikeThrough = 7
}
