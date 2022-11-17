namespace DocumentModel.Spreadsheet;

public enum Source
{
  
  [XmlEnum("worksheet")]
  Worksheet,
  
  [XmlEnum("external")]
  External,
  
  [XmlEnum("consolidation")]
  Consolidation,
  
  [XmlEnum("scenario")]
  Scenario,
}
