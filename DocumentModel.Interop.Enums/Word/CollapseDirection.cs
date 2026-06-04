namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction in which to collapse a range or selection.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcollapsedirection?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdCollapseDirection")]
public enum CollapseDirection
{
  /// <summary>
  /// Collapse the range to the ending point.
  /// </summary>
  [InteropEnumValue("wdCollapseEnd")]
  End = 0,
  /// <summary>
  /// Collapse the range to the starting point.
  /// </summary>
  [InteropEnumValue("wdCollapseStart")]
  Start = 1
}
