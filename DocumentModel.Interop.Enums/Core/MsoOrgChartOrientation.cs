namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation of an organization chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorgchartorientation?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoOrgChartOrientation")]
public enum OrgChartOrientation
{
  /// <summary>
  /// Mixed orientation.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartOrientationMixed")]
  Mixed = -2,
  /// <summary>
  /// Vertical orientation.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartOrientationVertical")]
  Vertical = 1
}
