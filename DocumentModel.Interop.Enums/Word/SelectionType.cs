namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdselectiontype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdSelectionType))]
public enum SelectionType
{
  /// <summary>
  /// No selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdNoSelection))]
  NoSelection = 0,
  /// <summary>
  /// An inline paragraph selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionIP))]
  SelectionIP = 1,
  /// <summary>
  /// A normal or user-defined selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionNormal))]
  SelectionNormal = 2,
  /// <summary>
  /// A frame selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionFrame))]
  SelectionFrame = 3,
  /// <summary>
  /// A column selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionColumn))]
  SelectionColumn = 4,
  /// <summary>
  /// A row selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionRow))]
  SelectionRow = 5,
  /// <summary>
  /// A block selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionBlock))]
  SelectionBlock = 6,
  /// <summary>
  /// An inline shape selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionInlineShape))]
  SelectionInlineShape = 7,
  /// <summary>
  /// A shape selection.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdSelectionType.wdSelectionShape))]
  SelectionShape = 8
}
