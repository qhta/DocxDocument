namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of selection.
/// </summary>
public enum WdSelectionType
{
  /// <summary>
  /// No selection.
  /// </summary>
  wdNoSelection = unchecked((int)0),
  /// <summary>
  /// An inline paragraph selection.
  /// </summary>
  wdSelectionIP = unchecked((int)1),
  /// <summary>
  /// A normal or user-defined selection.
  /// </summary>
  wdSelectionNormal = unchecked((int)2),
  /// <summary>
  /// A frame selection.
  /// </summary>
  wdSelectionFrame = unchecked((int)3),
  /// <summary>
  /// A column selection.
  /// </summary>
  wdSelectionColumn = unchecked((int)4),
  /// <summary>
  /// A row selection.
  /// </summary>
  wdSelectionRow = unchecked((int)5),
  /// <summary>
  /// A block selection.
  /// </summary>
  wdSelectionBlock = unchecked((int)6),
  /// <summary>
  /// An inline shape selection.
  /// </summary>
  wdSelectionInlineShape = unchecked((int)7),
  /// <summary>
  /// A shape selection.
  /// </summary>
  wdSelectionShape = unchecked((int)8)
}
