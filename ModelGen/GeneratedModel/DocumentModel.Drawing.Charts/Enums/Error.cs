namespace DocumentModel.Drawing.Charts;

public enum Error
{
  
  [XmlEnum("cust")]
  Custom,
  
  [XmlEnum("fixedVal")]
  FixedValue,
  
  [XmlEnum("percentage")]
  Percentage,
  
  [XmlEnum("stdDev")]
  StandardDeviation,
  
  [XmlEnum("stdErr")]
  StandardError,
}
