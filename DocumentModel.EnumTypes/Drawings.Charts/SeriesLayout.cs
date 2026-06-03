namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SeriesLayout enumeration.
/// Used in types such as ISeries, SeriesLayout, SeriesConverter.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SeriesLayout
{
  /// <summary>
  ///   boxWhisker.
  /// </summary>
  [OpenXmlEnumValue("BoxWhisker")]
  BoxWhisker,
  /// <summary>
  ///   clusteredColumn.
  /// </summary>
  [OpenXmlEnumValue("ClusteredColumn")]
  ClusteredColumn,
  /// <summary>
  ///   funnel.
  /// </summary>
  [OpenXmlEnumValue("Funnel")]
  Funnel,
  /// <summary>
  ///   paretoLine.
  /// </summary>
  [OpenXmlEnumValue("ParetoLine")]
  ParetoLine,
  /// <summary>
  ///   regionMap.
  /// </summary>
  [OpenXmlEnumValue("RegionMap")]
  RegionMap,
  /// <summary>
  ///   sunburst.
  /// </summary>
  [OpenXmlEnumValue("Sunburst")]
  Sunburst,
  /// <summary>
  ///   treemap.
  /// </summary>
  [OpenXmlEnumValue("Treemap")]
  Treemap,
  /// <summary>
  ///   waterfall.
  /// </summary>
  [OpenXmlEnumValue("Waterfall")]
  Waterfall
}

