namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the type of content control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontroltype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdContentControlType))]
public enum ContentControlType
{
  /// <summary>
  /// Specifies a rich-text content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRichText))]
  RichText = 0,
  /// <summary>
  /// Specifies a text content control
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlText))]
  Text = 1,
  /// <summary>
  /// Specifies a picture content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlPicture))]
  Picture = 2,
  /// <summary>
  /// Specifies a combo box content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlComboBox))]
  ComboBox = 3,
  /// <summary>
  /// Specifies a drop-down list content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlDropdownList))]
  DropdownList = 4,
  /// <summary>
  /// Specifies a building block gallery content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlBuildingBlockGallery))]
  BuildingBlockGallery = 5,
  /// <summary>
  /// Specifies a date content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlDate))]
  Date = 6,
  /// <summary>
  /// Specifies a group content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlGroup))]
  Group = 7,
  /// <summary>
  /// Specifies a checkbox content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlCheckBox))]
  CheckBox = 8,
  /// <summary>
  /// Specifies a repeating section content control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdContentControlType.wdContentControlRepeatingSection))]
  RepeatingSection = 9
}
