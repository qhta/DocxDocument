namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of selection.
/// </summary>
public enum WdSelectionType
{
  /// <summary>
  /// No selection.
  /// </summary>
  NoSelection = 0,
  /// <summary>
  /// An inline paragraph selection.
  /// </summary>
  SelectionIP = 1,
  /// <summary>
  /// A normal or user-defined selection.
  /// </summary>
  SelectionNormal = 2,
  /// <summary>
  /// A frame selection.
  /// </summary>
  SelectionFrame = 3,
  /// <summary>
  /// A column selection.
  /// </summary>
  SelectionColumn = 4,
  /// <summary>
  /// A row selection.
  /// </summary>
  SelectionRow = 5,
  /// <summary>
  /// A block selection.
  /// </summary>
  SelectionBlock = 6,
  /// <summary>
  /// An inline shape selection.
  /// </summary>
  SelectionInlineShape = 7,
  /// <summary>
  /// A shape selection.
  /// </summary>
  SelectionShape = 8
}
