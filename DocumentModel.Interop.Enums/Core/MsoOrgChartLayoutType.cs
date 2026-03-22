namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how to format the child nodes in an organization chart.
/// </summary>
public enum MsoOrgChartLayoutType
{
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  msoOrgChartLayoutMixed = -2,
  /// <summary>
  /// Places child nodes horizontally below the parent node. msoOrgChartLayoutBothHanging2 Places child nodes
  /// vertically below the parent node on both the left and the right side. msoOrgChartLayoutLeftHanging3 Places
  /// child nodes vertically below the parent node on the left side. msoOrgChartLayoutRightHanging4 Places child
  /// nodes vertically below the parent node on the right side. msoOrgChartLayoutDefault5
  /// </summary>
  msoOrgChartLayoutStandard = 1,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  msoOrgChartLayoutBothHanging = 2,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  msoOrgChartLayoutLeftHanging = 3,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  msoOrgChartLayoutRightHanging = 4,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  msoOrgChartLayoutDefault = 5
}
