namespace DocumentModel.Spreadsheet;

public enum Underline
{

  [XmlEnum("single")]
  Single,

  [XmlEnum("double")]
  Double,

  [XmlEnum("singleAccounting")]
  SingleAccounting,

  [XmlEnum("doubleAccounting")]
  DoubleAccounting,

  [XmlEnum("none")]
  None,
}
