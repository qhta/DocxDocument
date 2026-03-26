namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies orientation of an organization chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorgchartorientation?view=office-pia` for Office interop details.
/// </remarks>
public enum OrgChartOrientation
{
  /// <summary>
  /// Mixed orientation.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Vertical orientation.
  /// </summary>
  Vertical = 1
}
