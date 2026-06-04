namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position to which a selection or the insertion point is moved in relation to an object or to
/// itself.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdgotodirection?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdGoToDirection")]
public enum GoToDirection
{
  /// <summary>
  /// An absolute position.
  /// </summary>
  [WordInteropEnumValue("wdGoToAbsolute")]
  Absolute = 1,
  /// <summary>
  /// The first instance of the specified object.
  /// </summary>
  [WordInteropEnumValue("wdGoToFirst")]
  First = 1,
  /// <summary>
  /// The next instance of the specified object.
  /// </summary>
  [WordInteropEnumValue("wdGoToNext")]
  Next = 2,
  /// <summary>
  /// A position relative to the current position.
  /// </summary>
  [WordInteropEnumValue("wdGoToRelative")]
  Relative = 2,
  /// <summary>
  /// The previous instance of the specified object.
  /// </summary>
  [WordInteropEnumValue("wdGoToPrevious")]
  Previous = 3,
  /// <summary>
  /// The last instance of the specified object.
  /// </summary>
  [WordInteropEnumValue("wdGoToLast")]
  Last = -1
}
