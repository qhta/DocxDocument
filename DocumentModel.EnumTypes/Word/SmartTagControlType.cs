namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdsmarttagcontroltype?view=office-pia` for Office interop details.
/// </remarks>
public enum SmartTagControlType
{
  /// <summary>
  /// Smart tag.
  /// </summary>
  SmartTag = 1,
  /// <summary>
  /// Link.
  /// </summary>
  Link = 2,
  /// <summary>
  /// Help.
  /// </summary>
  Help = 3,
  /// <summary>
  /// Help URL.
  /// </summary>
  HelpURL = 4,
  /// <summary>
  /// Separator.
  /// </summary>
  Separator = 5,
  /// <summary>
  /// Button.
  /// </summary>
  Button = 6,
  /// <summary>
  /// Label.
  /// </summary>
  Label = 7,
  /// <summary>
  /// Image.
  /// </summary>
  Image = 8,
  /// <summary>
  /// Check box.
  /// </summary>
  Checkbox = 9,
  /// <summary>
  /// Text box.
  /// </summary>
  Textbox = 10,
  /// <summary>
  /// List box.
  /// </summary>
  Listbox = 11,
  /// <summary>
  /// Combo box.
  /// </summary>
  Combo = 12,
  /// <summary>
  /// ActiveX control.
  /// </summary>
  ActiveX = 13,
  /// <summary>
  /// Document fragment.
  /// </summary>
  DocumentFragment = 14,
  /// <summary>
  /// Document fragment URL.
  /// </summary>
  DocumentFragmentURL = 15,
  /// <summary>
  /// Radio group.
  /// </summary>
  RadioGroup = 16
}
