namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsmarttagcontroltype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSmartTagControlType))]
public enum SmartTagControlType
{
  /// <summary>
  /// Smart tag.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlSmartTag))]
  SmartTag = 1,
  /// <summary>
  /// Link.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlLink))]
  Link = 2,
  /// <summary>
  /// Help.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlHelp))]
  Help = 3,
  /// <summary>
  /// Help URL.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlHelpURL))]
  HelpURL = 4,
  /// <summary>
  /// Separator.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlSeparator))]
  Separator = 5,
  /// <summary>
  /// Button.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlButton))]
  Button = 6,
  /// <summary>
  /// Label.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlLabel))]
  Label = 7,
  /// <summary>
  /// Image.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlImage))]
  Image = 8,
  /// <summary>
  /// Check box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlCheckbox))]
  Checkbox = 9,
  /// <summary>
  /// Text box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlTextbox))]
  Textbox = 10,
  /// <summary>
  /// List box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlListbox))]
  Listbox = 11,
  /// <summary>
  /// Combo box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlCombo))]
  Combo = 12,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlActiveX))]
  ActiveX = 13,
  /// <summary>
  /// Document fragment.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlDocumentFragment))]
  DocumentFragment = 14,
  /// <summary>
  /// Document fragment URL.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlDocumentFragmentURL))]
  DocumentFragmentURL = 15,
  /// <summary>
  /// Radio group.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSmartTagControlType.wdControlRadioGroup))]
  RadioGroup = 16
}
