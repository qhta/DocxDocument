namespace DocumentModel.Interop.Word;

/// <summary>
/// Indicates the type of content control.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcontentcontroltype?view=office-pia` for Office interop details.
/// </remarks>
public enum ContentControlType
{
  /// <summary>
  /// Specifies a rich-text content control.
  /// </summary>
  RichText = 0,
  /// <summary>
  /// Specifies a text content control
  /// </summary>
  Text = 1,
  /// <summary>
  /// Specifies a picture content control.
  /// </summary>
  Picture = 2,
  /// <summary>
  /// Specifies a combo box content control.
  /// </summary>
  ComboBox = 3,
  /// <summary>
  /// Specifies a drop-down list content control.
  /// </summary>
  DropdownList = 4,
  /// <summary>
  /// Specifies a building block gallery content control.
  /// </summary>
  BuildingBlockGallery = 5,
  /// <summary>
  /// Specifies a date content control.
  /// </summary>
  Date = 6,
  /// <summary>
  /// Specifies a group content control.
  /// </summary>
  Group = 7,
  /// <summary>
  /// Specifies a checkbox content control.
  /// </summary>
  CheckBox = 8,
  /// <summary>
  /// Specifies a repeating section content control.
  /// </summary>
  RepeatingSection = 9
}
