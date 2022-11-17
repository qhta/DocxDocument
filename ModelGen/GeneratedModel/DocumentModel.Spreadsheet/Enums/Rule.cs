namespace DocumentModel.Spreadsheet;

public enum Rule
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("all")]
  All,
  
  [XmlEnum("row")]
  Row,
  
  [XmlEnum("column")]
  Column,
}
