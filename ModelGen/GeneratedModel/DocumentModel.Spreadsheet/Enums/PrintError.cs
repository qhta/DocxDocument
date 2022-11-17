namespace DocumentModel.Spreadsheet;

public enum PrintError
{

  [XmlEnum("displayed")]
  Displayed,

  [XmlEnum("blank")]
  Blank,

  [XmlEnum("dash")]
  Dash,

  [XmlEnum("NA")]
  NA,
}
