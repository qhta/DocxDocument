namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position to which a selection or the insertion point is moved in relation to an object or to
/// itself.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgotodirection?view=office-pia` for Office interop details.
/// </remarks>
public enum WdGoToDirection
{
  /// <summary>
  /// An absolute position.
  /// </summary>
  Absolute = 1,
  /// <summary>
  /// The first instance of the specified object.
  /// </summary>
  First = 1,
  /// <summary>
  /// The next instance of the specified object.
  /// </summary>
  Next = 2,
  /// <summary>
  /// A position relative to the current position.
  /// </summary>
  Relative = 2,
  /// <summary>
  /// The previous instance of the specified object.
  /// </summary>
  Previous = 3,
  /// <summary>
  /// Specifies the position to which a selection or the insertion point is moved in relation to an object or to
  /// itself.
  /// </summary>
  Last = -1
}
