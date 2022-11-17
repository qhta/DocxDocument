namespace DocumentModel.Office2013.Excel;

public enum SXVCellType
{

  [XmlEnum("b")]
  Boolean,

  [XmlEnum("n")]
  Number,

  [XmlEnum("e")]
  Error,

  [XmlEnum("str")]
  String,

  [XmlEnum("d")]
  Date,

  [XmlEnum("bl")]
  Blank,
}
