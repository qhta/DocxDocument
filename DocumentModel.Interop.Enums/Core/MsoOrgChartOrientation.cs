namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation of an organization chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorgchartorientation?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoOrgChartOrientation")]
public enum OrgChartOrientation
{
  /// <summary>
  /// Mixed orientation.
  /// </summary>
  [InteropEnumValue("msoOrgChartOrientationMixed")]
  Mixed = -2,
  /// <summary>
  /// Vertical orientation.
  /// </summary>
  [InteropEnumValue("msoOrgChartOrientationVertical")]
  Vertical = 1
}
