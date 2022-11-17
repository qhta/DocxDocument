namespace DocumentModel.Spreadsheet;

public enum MdxKPIProperty
{
  
  [XmlEnum("v")]
  Value,
  
  [XmlEnum("g")]
  Goal,
  
  [XmlEnum("s")]
  Status,
  
  [XmlEnum("t")]
  Trend,
  
  [XmlEnum("w")]
  Weight,
  
  [XmlEnum("m")]
  Time,
}
