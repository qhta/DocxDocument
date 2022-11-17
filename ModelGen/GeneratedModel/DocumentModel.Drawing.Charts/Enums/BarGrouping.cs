namespace DocumentModel.Drawing.Charts;

public enum BarGrouping
{
  
  [XmlEnum("percentStacked")]
  PercentStacked,
  
  [XmlEnum("clustered")]
  Clustered,
  
  [XmlEnum("standard")]
  Standard,
  
  [XmlEnum("stacked")]
  Stacked,
}
