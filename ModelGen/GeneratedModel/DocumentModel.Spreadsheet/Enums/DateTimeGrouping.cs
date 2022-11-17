namespace DocumentModel.Spreadsheet;

public enum DateTimeGrouping
{
  
  [XmlEnum("year")]
  Year,
  
  [XmlEnum("month")]
  Month,
  
  [XmlEnum("day")]
  Day,
  
  [XmlEnum("hour")]
  Hour,
  
  [XmlEnum("minute")]
  Minute,
  
  [XmlEnum("second")]
  Second,
}
