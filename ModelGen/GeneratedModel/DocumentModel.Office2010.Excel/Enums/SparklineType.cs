namespace DocumentModel.Office2010.Excel;

public enum SparklineType
{
  
  [XmlEnum("line")]
  Line,
  
  [XmlEnum("column")]
  Column,
  
  [XmlEnum("stacked")]
  Stacked,
}
