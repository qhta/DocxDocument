namespace DocumentModel.Spreadsheet;

public enum Dde
{
  
  [XmlEnum("nil")]
  Nil,
  
  [XmlEnum("b")]
  Boolean,
  
  [XmlEnum("n")]
  RealNumber,
  
  [XmlEnum("e")]
  Error,
  
  [XmlEnum("str")]
  String,
}
