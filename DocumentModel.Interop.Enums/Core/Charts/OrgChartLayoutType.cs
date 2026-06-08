namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how to format the child nodes in an organization chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorgchartlayouttype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoOrgChartLayoutType")]
public enum OrgChartLayoutType
{
  /// <summary>
  /// Return value for a parent node that has children formatted using more than one OrgChartLayoutType.
  /// </summary>
  [InteropEnumValue("msoOrgChartLayoutMixed")]
  Mixed = -2,
  /// <summary>
  /// Places child nodes horizontally below the parent node.
  /// </summary>
  [InteropEnumValue("msoOrgChartLayoutStandard")]
  Standard = 1,
  /// <summary>
  /// Places child nodes vertically below the parent node on both the left and the right side.
  /// </summary>
  [InteropEnumValue("msoOrgChartLayoutBothHanging")]
  BothHanging = 2,
  /// <summary>
  /// Places child nodes vertically below the parent node on the left side.
  /// </summary>
  [InteropEnumValue("msoOrgChartLayoutLeftHanging")]
  LeftHanging = 3,
  /// <summary>
  /// Places child nodes vertically below the parent node on the right side.
  /// </summary>
  [InteropEnumValue("msoOrgChartLayoutRightHanging")]
  RightHanging = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("msoOrgChartLayoutDefault")]
  Default = 5
}
