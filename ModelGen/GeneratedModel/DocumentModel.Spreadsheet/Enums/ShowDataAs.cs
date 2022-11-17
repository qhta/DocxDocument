namespace DocumentModel.Spreadsheet;

public enum ShowDataAs
{
  
  [XmlEnum("normal")]
  Normal,
  
  [XmlEnum("difference")]
  Difference,
  
  [XmlEnum("percent")]
  Percent,
  
  [XmlEnum("percentDiff")]
  PercentageDifference,
  
  [XmlEnum("runTotal")]
  RunTotal,
  
  [XmlEnum("percentOfRow")]
  PercentOfRaw,
  
  [XmlEnum("percentOfCol")]
  PercentOfColumn,
  
  [XmlEnum("percentOfTotal")]
  PercentOfTotal,
  
  [XmlEnum("index")]
  Index,
}
