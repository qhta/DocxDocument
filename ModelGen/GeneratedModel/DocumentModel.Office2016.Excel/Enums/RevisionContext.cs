namespace DocumentModel.Office2016.Excel;

public enum RevisionContext
{
  
  [XmlEnum("normal")]
  Normal,
  
  [XmlEnum("undo")]
  Undo,
  
  [XmlEnum("redo")]
  Redo,
  
  [XmlEnum("copy")]
  Copy,
}
