namespace DocumentModel.Spreadsheet;

public enum Visibility
{

  [XmlEnum("visible")]
  Visible,

  [XmlEnum("hidden")]
  Hidden,

  [XmlEnum("veryHidden")]
  VeryHidden,
}
