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
  wdGoToAbsolute = unchecked((int)1),
  /// <summary>
  /// The first instance of the specified object.
  /// </summary>
  wdGoToFirst = unchecked((int)1),
  /// <summary>
  /// The next instance of the specified object.
  /// </summary>
  wdGoToNext = unchecked((int)2),
  /// <summary>
  /// A position relative to the current position.
  /// </summary>
  wdGoToRelative = unchecked((int)2),
  /// <summary>
  /// The previous instance of the specified object.
  /// </summary>
  wdGoToPrevious = unchecked((int)3),
  /// <summary>
  /// Specifies the position to which a selection or the insertion point is moved in relation to an object or to
  /// itself.
  /// </summary>
  wdGoToLast = unchecked((int)-1)
}
