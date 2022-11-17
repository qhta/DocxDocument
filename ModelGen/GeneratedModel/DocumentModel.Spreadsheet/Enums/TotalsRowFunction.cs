namespace DocumentModel.Spreadsheet;

public enum TotalsRowFunction
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("sum")]
  Sum,
  
  [XmlEnum("min")]
  Minimum,
  
  [XmlEnum("max")]
  Maximum,
  
  [XmlEnum("average")]
  Average,
  
  [XmlEnum("count")]
  Count,
  
  [XmlEnum("countNums")]
  CountNumbers,
  
  [XmlEnum("stdDev")]
  StandardDeviation,
  
  [XmlEnum("var")]
  Variance,
  
  [XmlEnum("custom")]
  Custom,
}
