namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates how to format the child nodes in an organization chart.
/// </summary>
public enum MsoOrgChartLayoutType
{
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Places child nodes horizontally below the parent node. msoOrgChartLayoutBothHanging2 Places child nodes
  /// vertically below the parent node on both the left and the right side. msoOrgChartLayoutLeftHanging3 Places
  /// child nodes vertically below the parent node on the left side. msoOrgChartLayoutRightHanging4 Places child
  /// nodes vertically below the parent node on the right side. msoOrgChartLayoutDefault5
  /// </summary>
  Standard = 1,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  BothHanging = 2,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  LeftHanging = 3,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  RightHanging = 4,
  /// <summary>
  /// Indicates how to format the child nodes in an organization chart.
  /// </summary>
  Default = 5
}
