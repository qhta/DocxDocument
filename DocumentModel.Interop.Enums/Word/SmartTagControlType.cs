namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsmarttagcontroltype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSmartTagControlType")]
public enum SmartTagControlType
{
  /// <summary>
  /// Smart tag.
  /// </summary>
  [WordInteropEnumValue("wdControlSmartTag")]
  SmartTag = 1,
  /// <summary>
  /// Link.
  /// </summary>
  [WordInteropEnumValue("wdControlLink")]
  Link = 2,
  /// <summary>
  /// Help.
  /// </summary>
  [WordInteropEnumValue("wdControlHelp")]
  Help = 3,
  /// <summary>
  /// Help URL.
  /// </summary>
  [WordInteropEnumValue("wdControlHelpURL")]
  HelpURL = 4,
  /// <summary>
  /// Separator.
  /// </summary>
  [WordInteropEnumValue("wdControlSeparator")]
  Separator = 5,
  /// <summary>
  /// Button.
  /// </summary>
  [WordInteropEnumValue("wdControlButton")]
  Button = 6,
  /// <summary>
  /// Label.
  /// </summary>
  [WordInteropEnumValue("wdControlLabel")]
  Label = 7,
  /// <summary>
  /// Image.
  /// </summary>
  [WordInteropEnumValue("wdControlImage")]
  Image = 8,
  /// <summary>
  /// Check box.
  /// </summary>
  [WordInteropEnumValue("wdControlCheckbox")]
  Checkbox = 9,
  /// <summary>
  /// Text box.
  /// </summary>
  [WordInteropEnumValue("wdControlTextbox")]
  Textbox = 10,
  /// <summary>
  /// List box.
  /// </summary>
  [WordInteropEnumValue("wdControlListbox")]
  Listbox = 11,
  /// <summary>
  /// Combo box.
  /// </summary>
  [WordInteropEnumValue("wdControlCombo")]
  Combo = 12,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  [WordInteropEnumValue("wdControlActiveX")]
  ActiveX = 13,
  /// <summary>
  /// Document fragment.
  /// </summary>
  [WordInteropEnumValue("wdControlDocumentFragment")]
  DocumentFragment = 14,
  /// <summary>
  /// Document fragment URL.
  /// </summary>
  [WordInteropEnumValue("wdControlDocumentFragmentURL")]
  DocumentFragmentURL = 15,
  /// <summary>
  /// Radio group.
  /// </summary>
  [WordInteropEnumValue("wdControlRadioGroup")]
  RadioGroup = 16
}
