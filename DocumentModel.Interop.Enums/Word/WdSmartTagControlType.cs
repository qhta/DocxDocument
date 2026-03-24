namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of control associated with a SmartTagAction object.
/// </summary>
public enum WdSmartTagControlType
{
  /// <summary>
  /// Smart tag.
  /// </summary>
  SmartTag = unchecked((int)1),
  /// <summary>
  /// Link.
  /// </summary>
  Link = unchecked((int)2),
  /// <summary>
  /// Help.
  /// </summary>
  Help = unchecked((int)3),
  /// <summary>
  /// Help URL.
  /// </summary>
  HelpURL = unchecked((int)4),
  /// <summary>
  /// Separator.
  /// </summary>
  Separator = unchecked((int)5),
  /// <summary>
  /// Button.
  /// </summary>
  Button = unchecked((int)6),
  /// <summary>
  /// Label.
  /// </summary>
  Label = unchecked((int)7),
  /// <summary>
  /// Image.
  /// </summary>
  Image = unchecked((int)8),
  /// <summary>
  /// Check box.
  /// </summary>
  Checkbox = unchecked((int)9),
  /// <summary>
  /// Text box.
  /// </summary>
  Textbox = unchecked((int)10),
  /// <summary>
  /// List box. [System.Runtime.InteropServices.Guid("5BE83446-698C-3E28-A887-023C64E9DC57")] public enum
  /// WdSmartTagControlType ﾉ Expand table
  /// </summary>
  Listbox = unchecked((int)11),
  /// <summary>
  /// Combo box.
  /// </summary>
  Combo = unchecked((int)12),
  /// <summary>
  /// ActiveX control.
  /// </summary>
  ActiveX = unchecked((int)13),
  /// <summary>
  /// Document fragment.
  /// </summary>
  DocumentFragment = unchecked((int)14),
  /// <summary>
  /// Document fragment URL.
  /// </summary>
  DocumentFragmentURL = unchecked((int)15),
  /// <summary>
  /// Radio group.
  /// </summary>
  RadioGroup = unchecked((int)16)
}
