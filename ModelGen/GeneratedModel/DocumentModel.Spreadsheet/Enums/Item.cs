namespace DocumentModel.Spreadsheet;

public enum Item
{

  [XmlEnum("data")]
  Data,

  [XmlEnum("default")]
  Default,

  [XmlEnum("sum")]
  Sum,

  [XmlEnum("countA")]
  CountA,

  [XmlEnum("avg")]
  Average,

  [XmlEnum("max")]
  Maximum,

  [XmlEnum("min")]
  Minimum,

  [XmlEnum("product")]
  Product,

  [XmlEnum("count")]
  Count,

  [XmlEnum("stdDev")]
  StandardDeviation,

  [XmlEnum("stdDevP")]
  StandardDeviationP,

  [XmlEnum("var")]
  Variance,

  [XmlEnum("varP")]
  VarianceP,

  [XmlEnum("grand")]
  Grand,

  [XmlEnum("blank")]
  Blank,
}
