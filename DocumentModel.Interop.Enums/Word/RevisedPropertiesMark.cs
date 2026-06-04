namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how revisions are displayed when change tracking is enabled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisedpropertiesmark?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark))]
public enum RevisedPropertiesMark
{
  /// <summary>
  /// Using a special character.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkNone))]
  None = 0,
  /// <summary>
  /// In bold.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkBold))]
  Bold = 1,
  /// <summary>
  /// In italics.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkItalic))]
  Italic = 2,
  /// <summary>
  /// With underline characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkUnderline))]
  Underline = 3,
  /// <summary>
  /// With double underline characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkDoubleUnderline))]
  DoubleUnderline = 4,
  /// <summary>
  /// In the designated color.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkColorOnly))]
  ColorOnly = 5,
  /// <summary>
  /// Using strikethrough characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkStrikeThrough))]
  StrikeThrough = 6,
  /// <summary>
  /// Using double-strikethrough characters.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRevisedPropertiesMark.wdRevisedPropertiesMarkDoubleStrikeThrough))]
  DoubleStrikeThrough = 7
}
