namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how to format the child nodes in an organization chart.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoorgchartlayouttype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoOrgChartLayoutType")]
public enum OrgChartLayoutType
{
  /// <summary>
  /// Return value for a parent node that has children formatted using more than one OrgChartLayoutType.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartLayoutMixed")]
  Mixed = -2,
  /// <summary>
  /// Places child nodes horizontally below the parent node.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartLayoutStandard")]
  Standard = 1,
  /// <summary>
  /// Places child nodes vertically below the parent node on both the left and the right side.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartLayoutBothHanging")]
  BothHanging = 2,
  /// <summary>
  /// Places child nodes vertically below the parent node on the left side.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartLayoutLeftHanging")]
  LeftHanging = 3,
  /// <summary>
  /// Places child nodes vertically below the parent node on the right side.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartLayoutRightHanging")]
  RightHanging = 4,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("msoOrgChartLayoutDefault")]
  Default = 5
}
