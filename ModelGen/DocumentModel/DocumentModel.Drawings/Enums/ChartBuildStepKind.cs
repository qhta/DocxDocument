namespace DocumentModel.Drawings;

/// <summary>
/// Chart Animation Build Step
/// </summary>
public enum ChartBuildStepKind
{
  /// <summary>
  /// Category.
  /// </summary>
  [XmlEnum("category")]
  Category,
  
  /// <summary>
  /// Category Points.
  /// </summary>
  [XmlEnum("ptInCategory")]
  CategoryPoints,
  
  /// <summary>
  /// Series.
  /// </summary>
  [XmlEnum("series")]
  Series,
  
  /// <summary>
  /// Series Points.
  /// </summary>
  [XmlEnum("ptInSeries")]
  SeriesPoints,
  
  /// <summary>
  /// All Points.
  /// </summary>
  [XmlEnum("allPts")]
  AllPoints,
  
  /// <summary>
  /// Grid and Legend.
  /// </summary>
  [XmlEnum("gridLegend")]
  GridLegend,
  
}
