namespace DocumentModel.Office2016.Excel;

public enum SheetOp
{
  
  [XmlEnum("insert")]
  Insert,
  
  [XmlEnum("delete")]
  Delete,
  
  [XmlEnum("reorder")]
  Reorder,
  
  [XmlEnum("rename")]
  Rename,
}
