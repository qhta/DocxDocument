namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type for a segment.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msosegmenttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoSegmentType")]
public enum SegmentType
{
  /// <summary>
  /// Line.
  /// </summary>
  [InteropEnumValue("msoSegmentLine")]
  Line,
  /// <summary>
  /// Curve.
  /// </summary>
  [InteropEnumValue("msoSegmentCurve")]
  Curve
}
