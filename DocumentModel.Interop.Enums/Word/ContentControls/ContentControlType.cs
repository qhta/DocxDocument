namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the type of content control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontroltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdContentControlType")]
public enum ContentControlType
{
  /// <summary>
  /// Specifies a rich-text content control.
  /// </summary>
  [InteropEnumValue("wdContentControlRichText")]
  RichText = 0,
  /// <summary>
  /// Specifies a text content control
  /// </summary>
  [InteropEnumValue("wdContentControlText")]
  Text = 1,
  /// <summary>
  /// Specifies a picture content control.
  /// </summary>
  [InteropEnumValue("wdContentControlPicture")]
  Picture = 2,
  /// <summary>
  /// Specifies a combo box content control.
  /// </summary>
  [InteropEnumValue("wdContentControlComboBox")]
  ComboBox = 3,
  /// <summary>
  /// Specifies a drop-down list content control.
  /// </summary>
  [InteropEnumValue("wdContentControlDropdownList")]
  DropdownList = 4,
  /// <summary>
  /// Specifies a building block gallery content control.
  /// </summary>
  [InteropEnumValue("wdContentControlBuildingBlockGallery")]
  BuildingBlockGallery = 5,
  /// <summary>
  /// Specifies a date content control.
  /// </summary>
  [InteropEnumValue("wdContentControlDate")]
  Date = 6,
  /// <summary>
  /// Specifies a group content control.
  /// </summary>
  [InteropEnumValue("wdContentControlGroup")]
  Group = 7,
  /// <summary>
  /// Specifies a checkbox content control.
  /// </summary>
  [InteropEnumValue("wdContentControlCheckBox")]
  CheckBox = 8,
  /// <summary>
  /// Specifies a repeating section content control.
  /// </summary>
  [InteropEnumValue("wdContentControlRepeatingSection")]
  RepeatingSection = 9
}
