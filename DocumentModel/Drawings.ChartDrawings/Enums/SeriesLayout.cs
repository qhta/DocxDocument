namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the SeriesLayout enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SeriesLayout
{
  /// <summary>
  ///   boxWhisker.
  /// </summary>
  BoxWhisker,

  /// <summary>
  ///   clusteredColumn.
  /// </summary>
  ClusteredColumn,

  /// <summary>
  ///   funnel.
  /// </summary>
  Funnel,

  /// <summary>
  ///   paretoLine.
  /// </summary>
  ParetoLine,

  /// <summary>
  ///   regionMap.
  /// </summary>
  RegionMap,

  /// <summary>
  ///   sunburst.
  /// </summary>
  Sunburst,

  /// <summary>
  ///   treemap.
  /// </summary>
  Treemap,

  /// <summary>
  ///   waterfall.
  /// </summary>
  Waterfall
}