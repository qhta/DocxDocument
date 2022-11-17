namespace DocumentModel.Wordprocessing;

public enum MailMergeData
{
  
  [XmlEnum("textFile")]
  TextFile,
  
  [XmlEnum("database")]
  Database,
  
  [XmlEnum("spreadsheet")]
  Spreadsheet,
  
  [XmlEnum("query")]
  Query,
  
  [XmlEnum("odbc")]
  Odbc,
  
  [XmlEnum("native")]
  Native,
}
