namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which to collapse a range or selection.
/// </summary>
public enum WdCollapseDirection
{
  /// <summary>
  /// Collapse the range to the ending point.
  /// </summary>
  wdCollapseEnd = unchecked((int)0),
  /// <summary>
  /// Collapse the range to the starting point.
  /// </summary>
  wdCollapseStart = unchecked((int)1)
}
