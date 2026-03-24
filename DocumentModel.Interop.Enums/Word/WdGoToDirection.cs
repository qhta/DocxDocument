namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position to which a selection or the insertion point is moved in relation to an object or to
/// itself.
/// </summary>
public enum WdGoToDirection
{
  /// <summary>
  /// An absolute position.
  /// </summary>
  Absolute = unchecked((int)1),
  /// <summary>
  /// The first instance of the specified object.
  /// </summary>
  First = unchecked((int)1),
  /// <summary>
  /// The next instance of the specified object.
  /// </summary>
  Next = unchecked((int)2),
  /// <summary>
  /// A position relative to the current position.
  /// </summary>
  Relative = unchecked((int)2),
  /// <summary>
  /// The previous instance of the specified object.
  /// </summary>
  Previous = unchecked((int)3),
  /// <summary>
  /// Specifies the position to which a selection or the insertion point is moved in relation to an object or to
  /// itself.
  /// </summary>
  Last = unchecked((int)-1)
}
