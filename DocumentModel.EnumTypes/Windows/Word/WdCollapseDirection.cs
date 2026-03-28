namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which to collapse a range or selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcollapsedirection?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCollapseDirection
{
  /// <summary>
  /// Collapse the range to the ending point.
  /// </summary>
  End = 0,
  /// <summary>
  /// Collapse the range to the starting point.
  /// </summary>
  Start = 1
}
