namespace DocumentModel.Office2010.Excel;

public enum PivotEditValueType
{
  
  [XmlEnum("number")]
  Number,
  
  [XmlEnum("dateTime")]
  DateTime,
  
  [XmlEnum("string")]
  String,
  
  [XmlEnum("boolean")]
  Boolean,
  
  [XmlEnum("error")]
  Error,
}
