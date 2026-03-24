namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the type of content control.
/// </summary>
public enum WdContentControlType
{
  /// <summary>
  /// Specifies a rich-text content control.
  /// </summary>
  RichText = unchecked((int)0),
  /// <summary>
  /// Specifies a text content control
  /// </summary>
  Text = unchecked((int)1),
  /// <summary>
  /// Specifies a picture content control.
  /// </summary>
  Picture = unchecked((int)2),
  /// <summary>
  /// Specifies a combo box content control.
  /// </summary>
  ComboBox = unchecked((int)3),
  /// <summary>
  /// Specifies a drop-down list content control. wdContentControlBuildingBlockGallery5 Specifies a building block
  /// gallery content control.
  /// </summary>
  DropdownList = unchecked((int)4),
  /// <summary>
  /// Indicates the type of content control.
  /// </summary>
  BuildingBlockGallery = unchecked((int)5),
  /// <summary>
  /// Specifies a date content control.
  /// </summary>
  Date = unchecked((int)6),
  /// <summary>
  /// Specifies a group content control.
  /// </summary>
  Group = unchecked((int)7),
  /// <summary>
  /// Specifies a checkbox content control.
  /// </summary>
  CheckBox = unchecked((int)8),
  /// <summary>
  /// Specifies a repeating section content control.
  /// [System.Runtime.InteropServices.Guid("D837E0A6-EB0E-3F7F-B8BE-9C0F05401CCD")] public enum WdContentControlType
  /// ﾉ Expand table
  /// </summary>
  RepeatingSection = unchecked((int)9)
}
