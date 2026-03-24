namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
public enum WdSmartTagControlType
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
  /// List box. [System.Runtime.InteropServices.Guid("5BE83446-698C-3E28-A887-023C64E9DC57")] public enum
  /// WdSmartTagControlType ﾉ Expand table
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
