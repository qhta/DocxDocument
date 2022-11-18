namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the SeriesLayout enumeration.
/// </summary>
public enum SeriesLayout
{
  /// <summary>
  /// boxWhisker.
  /// </summary>
  [XmlEnum("boxWhisker")]
  BoxWhisker,
  
  /// <summary>
  /// clusteredColumn.
  /// </summary>
  [XmlEnum("clusteredColumn")]
  ClusteredColumn,
  
  /// <summary>
  /// funnel.
  /// </summary>
  [XmlEnum("funnel")]
  Funnel,
  
  /// <summary>
  /// paretoLine.
  /// </summary>
  [XmlEnum("paretoLine")]
  ParetoLine,
  
  /// <summary>
  /// regionMap.
  /// </summary>
  [XmlEnum("regionMap")]
  RegionMap,
  
  /// <summary>
  /// sunburst.
  /// </summary>
  [XmlEnum("sunburst")]
  Sunburst,
  
  /// <summary>
  /// treemap.
  /// </summary>
  [XmlEnum("treemap")]
  Treemap,
  
  /// <summary>
  /// waterfall.
  /// </summary>
  [XmlEnum("waterfall")]
  Waterfall,
  
}
