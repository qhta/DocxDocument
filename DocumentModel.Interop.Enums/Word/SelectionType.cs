namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdselectiontype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdSelectionType")]
public enum SelectionType
{
  /// <summary>
  /// No selection.
  /// </summary>
  [WordInteropEnumValue("wdNoSelection")]
  NoSelection = 0,
  /// <summary>
  /// An inline paragraph selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionIP")]
  SelectionIP = 1,
  /// <summary>
  /// A normal or user-defined selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionNormal")]
  SelectionNormal = 2,
  /// <summary>
  /// A frame selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionFrame")]
  SelectionFrame = 3,
  /// <summary>
  /// A column selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionColumn")]
  SelectionColumn = 4,
  /// <summary>
  /// A row selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionRow")]
  SelectionRow = 5,
  /// <summary>
  /// A block selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionBlock")]
  SelectionBlock = 6,
  /// <summary>
  /// An inline shape selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionInlineShape")]
  SelectionInlineShape = 7,
  /// <summary>
  /// A shape selection.
  /// </summary>
  [WordInteropEnumValue("wdSelectionShape")]
  SelectionShape = 8
}
