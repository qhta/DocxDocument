namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the way the selection is moved.
/// </summary>
public enum WdMovementType
{
  /// <summary>
  /// The selection is collapsed to an insertion point and moved to the end of the specified unit. Default.
  /// wdExtend1 The end of the selection is extended to the end of the specified unit.
  /// </summary>
  Move = 0,
  /// <summary>
  /// Specifies the way the selection is moved.
  /// </summary>
  Extend = 1
}
