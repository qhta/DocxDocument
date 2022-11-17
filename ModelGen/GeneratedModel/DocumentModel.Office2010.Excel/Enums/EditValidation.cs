namespace DocumentModel.Office2010.Excel;

public enum EditValidation
{

  [XmlEnum("text")]
  Text,

  [XmlEnum("integer")]
  Integer,

  [XmlEnum("number")]
  Number,

  [XmlEnum("reference")]
  Reference,

  [XmlEnum("formula")]
  Formula,
}
