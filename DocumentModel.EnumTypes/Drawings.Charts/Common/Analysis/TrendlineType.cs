namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Trendline enumeration.
/// Used in types such as AreaChartSeries, AreaChartSeries3, BarChartSeries.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.TrendlineValues))]
public enum TrendlineType
{
  /// <summary>
  ///   Exponential.
  /// </summary>
  [OpenXmlEnumValue("Exponential")]
  Exponential,
  /// <summary>
  ///   Linear.
  /// </summary>
  [OpenXmlEnumValue("Linear")]
  Linear,
  /// <summary>
  ///   Logarithmic.
  /// </summary>
  [OpenXmlEnumValue("Logarithmic")]
  Logarithmic,
  /// <summary>
  ///   Moving Average.
  /// </summary>
  [OpenXmlEnumValue("MovingAverage")]
  MovingAverage,
  /// <summary>
  ///   Polynomial.
  /// </summary>
  [OpenXmlEnumValue("Polynomial")]
  Polynomial,
  /// <summary>
  ///   Power.
  /// </summary>
  [OpenXmlEnumValue("Power")]
  Power
}
