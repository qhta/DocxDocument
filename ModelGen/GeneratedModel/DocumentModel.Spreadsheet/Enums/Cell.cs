namespace DocumentModel.Spreadsheet;

public enum Cell
{

  [XmlEnum("b")]
  Boolean,

  [XmlEnum("n")]
  Number,

  [XmlEnum("e")]
  Error,

  [XmlEnum("s")]
  SharedString,

  [XmlEnum("str")]
  String,

  [XmlEnum("inlineStr")]
  InlineString,

  [XmlEnum("d")]
  Date,
}
