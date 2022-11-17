namespace DocumentModel.Spreadsheet;

public enum GrowShrink
{
  
  [XmlEnum("insertDelete")]
  InsertDelete,
  
  [XmlEnum("insertClear")]
  InsertClear,
  
  [XmlEnum("overwriteClear")]
  OverwriteClear,
}
