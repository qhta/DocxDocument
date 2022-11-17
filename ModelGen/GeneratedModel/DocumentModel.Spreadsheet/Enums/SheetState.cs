namespace DocumentModel.Spreadsheet;

public enum SheetState
{
  
  [XmlEnum("visible")]
  Visible,
  
  [XmlEnum("hidden")]
  Hidden,
  
  [XmlEnum("veryHidden")]
  VeryHidden,
}
