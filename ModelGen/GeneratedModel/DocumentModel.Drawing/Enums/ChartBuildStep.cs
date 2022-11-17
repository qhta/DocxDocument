namespace DocumentModel.Drawing;

public enum ChartBuildStep
{
  
  [XmlEnum("category")]
  Category,
  
  [XmlEnum("ptInCategory")]
  CategoryPoints,
  
  [XmlEnum("series")]
  Series,
  
  [XmlEnum("ptInSeries")]
  SeriesPoints,
  
  [XmlEnum("allPts")]
  AllPoints,
  
  [XmlEnum("gridLegend")]
  GridLegend,
}
