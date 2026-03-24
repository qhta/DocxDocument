namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of selection.
/// </summary>
public enum WdSelectionType
{
  /// <summary>
  /// No selection.
  /// </summary>
  NoSelection = unchecked((int)0),
  /// <summary>
  /// An inline paragraph selection.
  /// </summary>
  SelectionIP = unchecked((int)1),
  /// <summary>
  /// A normal or user-defined selection.
  /// </summary>
  SelectionNormal = unchecked((int)2),
  /// <summary>
  /// A frame selection.
  /// </summary>
  SelectionFrame = unchecked((int)3),
  /// <summary>
  /// A column selection.
  /// </summary>
  SelectionColumn = unchecked((int)4),
  /// <summary>
  /// A row selection.
  /// </summary>
  SelectionRow = unchecked((int)5),
  /// <summary>
  /// A block selection.
  /// </summary>
  SelectionBlock = unchecked((int)6),
  /// <summary>
  /// An inline shape selection.
  /// </summary>
  SelectionInlineShape = unchecked((int)7),
  /// <summary>
  /// A shape selection.
  /// </summary>
  SelectionShape = unchecked((int)8)
}
