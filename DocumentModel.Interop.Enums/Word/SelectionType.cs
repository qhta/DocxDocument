namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdselectiontype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdSelectionType")]
public enum SelectionType
{
  /// <summary>
  /// No selection.
  /// </summary>
  [InteropEnumValue("wdNoSelection")]
  NoSelection = 0,
  /// <summary>
  /// An inline paragraph selection.
  /// </summary>
  [InteropEnumValue("wdSelectionIP")]
  SelectionIP = 1,
  /// <summary>
  /// A normal or user-defined selection.
  /// </summary>
  [InteropEnumValue("wdSelectionNormal")]
  SelectionNormal = 2,
  /// <summary>
  /// A frame selection.
  /// </summary>
  [InteropEnumValue("wdSelectionFrame")]
  SelectionFrame = 3,
  /// <summary>
  /// A column selection.
  /// </summary>
  [InteropEnumValue("wdSelectionColumn")]
  SelectionColumn = 4,
  /// <summary>
  /// A row selection.
  /// </summary>
  [InteropEnumValue("wdSelectionRow")]
  SelectionRow = 5,
  /// <summary>
  /// A block selection.
  /// </summary>
  [InteropEnumValue("wdSelectionBlock")]
  SelectionBlock = 6,
  /// <summary>
  /// An inline shape selection.
  /// </summary>
  [InteropEnumValue("wdSelectionInlineShape")]
  SelectionInlineShape = 7,
  /// <summary>
  /// A shape selection.
  /// </summary>
  [InteropEnumValue("wdSelectionShape")]
  SelectionShape = 8
}
