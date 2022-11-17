namespace DocumentModel.Spreadsheet;

public enum Scope
{

  [XmlEnum("selection")]
  Selection,

  [XmlEnum("data")]
  Data,

  [XmlEnum("field")]
  Field,
}
