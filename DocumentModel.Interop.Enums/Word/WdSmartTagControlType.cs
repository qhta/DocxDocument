namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
public enum WdSmartTagControlType
{
  /// <summary>
  /// Smart tag.
  /// </summary>
  wdControlSmartTag = unchecked((int)1),
  /// <summary>
  /// Link.
  /// </summary>
  wdControlLink = unchecked((int)2),
  /// <summary>
  /// Help.
  /// </summary>
  wdControlHelp = unchecked((int)3),
  /// <summary>
  /// Help URL.
  /// </summary>
  wdControlHelpURL = unchecked((int)4),
  /// <summary>
  /// Separator.
  /// </summary>
  wdControlSeparator = unchecked((int)5),
  /// <summary>
  /// Button.
  /// </summary>
  wdControlButton = unchecked((int)6),
  /// <summary>
  /// Label.
  /// </summary>
  wdControlLabel = unchecked((int)7),
  /// <summary>
  /// Image.
  /// </summary>
  wdControlImage = unchecked((int)8),
  /// <summary>
  /// Check box.
  /// </summary>
  wdControlCheckbox = unchecked((int)9),
  /// <summary>
  /// Text box.
  /// </summary>
  wdControlTextbox = unchecked((int)10),
  /// <summary>
  /// List box. [System.Runtime.InteropServices.Guid("5BE83446-698C-3E28-A887-023C64E9DC57")] public enum
  /// WdSmartTagControlType ﾉ Expand table
  /// </summary>
  wdControlListbox = unchecked((int)11),
  /// <summary>
  /// Combo box.
  /// </summary>
  wdControlCombo = unchecked((int)12),
  /// <summary>
  /// ActiveX control.
  /// </summary>
  wdControlActiveX = unchecked((int)13),
  /// <summary>
  /// Document fragment.
  /// </summary>
  wdControlDocumentFragment = unchecked((int)14),
  /// <summary>
  /// Document fragment URL.
  /// </summary>
  wdControlDocumentFragmentURL = unchecked((int)15),
  /// <summary>
  /// Radio group.
  /// </summary>
  wdControlRadioGroup = unchecked((int)16)
}
