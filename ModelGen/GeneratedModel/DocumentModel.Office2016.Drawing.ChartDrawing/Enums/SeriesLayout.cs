namespace DocumentModel.Office2016.Drawing.ChartDrawing;

public enum SeriesLayout
{

  [XmlEnum("boxWhisker")]
  BoxWhisker,

  [XmlEnum("clusteredColumn")]
  ClusteredColumn,

  [XmlEnum("funnel")]
  Funnel,

  [XmlEnum("paretoLine")]
  ParetoLine,

  [XmlEnum("regionMap")]
  RegionMap,

  [XmlEnum("sunburst")]
  Sunburst,

  [XmlEnum("treemap")]
  Treemap,

  [XmlEnum("waterfall")]
  Waterfall,
}
