namespace DocumentModel.Spreadsheet;

public enum DataConsolidateFunction
{

  [XmlEnum("average")]
  Average,

  [XmlEnum("count")]
  Count,

  [XmlEnum("countNums")]
  CountNumbers,

  [XmlEnum("max")]
  Maximum,

  [XmlEnum("min")]
  Minimum,

  [XmlEnum("product")]
  Product,

  [XmlEnum("stdDev")]
  StandardDeviation,

  [XmlEnum("stdDevp")]
  StandardDeviationP,

  [XmlEnum("sum")]
  Sum,

  [XmlEnum("var")]
  Variance,

  [XmlEnum("varp")]
  VarianceP,
}
