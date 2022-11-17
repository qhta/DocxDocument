namespace DocumentModel.Presentation;

public enum ChartSubElement
{
  
  [XmlEnum("gridLegend")]
  GridLegend,
  
  [XmlEnum("series")]
  Series,
  
  [XmlEnum("category")]
  Category,
  
  [XmlEnum("ptInSeries")]
  PointInSeries,
  
  [XmlEnum("ptInCategory")]
  PointInCategory,
}
