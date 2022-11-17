namespace DocumentModel.Presentation;

public enum OleChartBuild
{
  
  [XmlEnum("allAtOnce")]
  AllAtOnce,
  
  [XmlEnum("series")]
  Series,
  
  [XmlEnum("category")]
  Category,
  
  [XmlEnum("seriesEl")]
  SeriesElement,
  
  [XmlEnum("categoryEl")]
  CategoryElement,
}
