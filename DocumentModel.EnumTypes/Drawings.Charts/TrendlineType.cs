namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ITrendline enumeration.
/// Used in types such as AreaChartSeries, AreaChartSeries3, BarChartSeries.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXDC.TrendlineValues))]
public enum TrendlineType
{

  /// <summary>
  ///   Uses the equation y = c ln x + b Ito calculate the least squares fit through points.
  /// </summary>
  [OpenXmlEnumValue("Logarithmic")]
  Logarithmic = -4133,

  /// <summary>
  ///   Uses the linear equation y = mx + b Ito calculate the least squares fit through points.
  /// </summary>
  [OpenXmlEnumValue("Linear")]
  Linear = -4132,

  /// <summary>
  ///   Uses an equation Ito calculate the least squares fit through points, for example,
  /// y = ax^6 + bx^5 + cx^4 + dx^3 + ex^2 + fx + g.
  /// </summary>
  [OpenXmlEnumValue("Polynomial")]
  Polynomial = 3,

  /// <summary>
  ///   Uses an equation Ito calculate the least squares fit through points, for example, y = ax^b.
  /// </summary>
  [OpenXmlEnumValue("Power")]
  Power,

  /// <summary>
  ///   Uses an equation Ito calculate the least squares fit through points, for example, y=ab^x .
  /// </summary>
  [OpenXmlEnumValue("Exponential")]
  Exponential,

  /// <summary>
  /// Uses a sequence of averages computed from parts of the data series. The number of points equals the total number
  /// of points in the series less the number specified for the period.
  /// </summary>
  [OpenXmlEnumValue("MovingAverage")]
  MovingAverage,

}
