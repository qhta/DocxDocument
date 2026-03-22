namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the insertion point progresses within bidirectional text.
/// </summary>
public enum WdCursorMovement
{
  /// <summary>
  /// Specifies how the insertion point progresses within bidirectional text.
  /// </summary>
  wdCursorMovementLogical = unchecked((int)0),
  /// <summary>
  /// Specifies how the insertion point progresses within bidirectional text.
  /// </summary>
  wdCursorMovementVisual = unchecked((int)1)
}
