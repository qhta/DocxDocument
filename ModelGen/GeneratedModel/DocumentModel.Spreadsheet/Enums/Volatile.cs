namespace DocumentModel.Spreadsheet;

public enum Volatile
{
  
  [XmlEnum("b")]
  Boolean,
  
  [XmlEnum("n")]
  RealNumber,
  
  [XmlEnum("e")]
  Error,
  
  [XmlEnum("s")]
  String,
}
