namespace DocumentModel.Spreadsheet;

public enum DataValidation
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("whole")]
  Whole,
  
  [XmlEnum("decimal")]
  Decimal,
  
  [XmlEnum("list")]
  List,
  
  [XmlEnum("date")]
  Date,
  
  [XmlEnum("time")]
  Time,
  
  [XmlEnum("textLength")]
  TextLength,
  
  [XmlEnum("custom")]
  Custom,
}
