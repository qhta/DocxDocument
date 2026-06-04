namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsmarttagcontroltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSmartTagControlType")]
public enum SmartTagControlType
{
  /// <summary>
  /// Smart tag.
  /// </summary>
  [InteropEnumValue("wdControlSmartTag")]
  SmartTag = 1,
  /// <summary>
  /// Link.
  /// </summary>
  [InteropEnumValue("wdControlLink")]
  Link = 2,
  /// <summary>
  /// Help.
  /// </summary>
  [InteropEnumValue("wdControlHelp")]
  Help = 3,
  /// <summary>
  /// Help URL.
  /// </summary>
  [InteropEnumValue("wdControlHelpURL")]
  HelpURL = 4,
  /// <summary>
  /// Separator.
  /// </summary>
  [InteropEnumValue("wdControlSeparator")]
  Separator = 5,
  /// <summary>
  /// Button.
  /// </summary>
  [InteropEnumValue("wdControlButton")]
  Button = 6,
  /// <summary>
  /// Label.
  /// </summary>
  [InteropEnumValue("wdControlLabel")]
  Label = 7,
  /// <summary>
  /// Image.
  /// </summary>
  [InteropEnumValue("wdControlImage")]
  Image = 8,
  /// <summary>
  /// Check box.
  /// </summary>
  [InteropEnumValue("wdControlCheckbox")]
  Checkbox = 9,
  /// <summary>
  /// Text box.
  /// </summary>
  [InteropEnumValue("wdControlTextbox")]
  Textbox = 10,
  /// <summary>
  /// List box.
  /// </summary>
  [InteropEnumValue("wdControlListbox")]
  Listbox = 11,
  /// <summary>
  /// Combo box.
  /// </summary>
  [InteropEnumValue("wdControlCombo")]
  Combo = 12,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  [InteropEnumValue("wdControlActiveX")]
  ActiveX = 13,
  /// <summary>
  /// Document fragment.
  /// </summary>
  [InteropEnumValue("wdControlDocumentFragment")]
  DocumentFragment = 14,
  /// <summary>
  /// Document fragment URL.
  /// </summary>
  [InteropEnumValue("wdControlDocumentFragmentURL")]
  DocumentFragmentURL = 15,
  /// <summary>
  /// Radio group.
  /// </summary>
  [InteropEnumValue("wdControlRadioGroup")]
  RadioGroup = 16
}
