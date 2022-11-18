namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Trendline Type
/// </summary>
public enum Trendline
{
  /// <summary>
  /// Exponential.
  /// </summary>
  [XmlEnum("exp")]
  Exponential,
  
  /// <summary>
  /// Linear.
  /// </summary>
  [XmlEnum("linear")]
  Linear,
  
  /// <summary>
  /// Logarithmic.
  /// </summary>
  [XmlEnum("log")]
  Logarithmic,
  
  /// <summary>
  /// Moving Average.
  /// </summary>
  [XmlEnum("movingAvg")]
  MovingAverage,
  
  /// <summary>
  /// Polynomial.
  /// </summary>
  [XmlEnum("poly")]
  Polynomial,
  
  /// <summary>
  /// Power.
  /// </summary>
  [XmlEnum("power")]
  Power,
  
}
