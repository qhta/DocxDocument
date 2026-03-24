namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the state (shape) of the cursor.
/// </summary>
public enum WdCursorType
{
  /// <summary>
  /// Hourglass cursor shape.
  /// </summary>
  Wait = 0,
  /// <summary>
  /// I-beam cursor shape.
  /// </summary>
  IBeam = 1,
  /// <summary>
  /// Normal cursor shape. Default; cursor takes shape designated by Microsoft Windows or the application.
  /// wdCursorNorthwestArrow3 Diagonal cursor shape starting at top left corner.
  /// </summary>
  Normal = 2,
  /// <summary>
  /// Specifies the state (shape) of the cursor.
  /// </summary>
  NorthwestArrow = 3
}
