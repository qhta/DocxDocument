namespace DocumentModel.Drawing.Charts;

public enum Trendline
{
  
  [XmlEnum("exp")]
  Exponential,
  
  [XmlEnum("linear")]
  Linear,
  
  [XmlEnum("log")]
  Logarithmic,
  
  [XmlEnum("movingAvg")]
  MovingAverage,
  
  [XmlEnum("poly")]
  Polynomial,
  
  [XmlEnum("power")]
  Power,
}
