namespace DocumentModel.Spreadsheet;

public enum Table
{
  
  [XmlEnum("worksheet")]
  Worksheet,
  
  [XmlEnum("xml")]
  Xml,
  
  [XmlEnum("queryTable")]
  QueryTable,
}
