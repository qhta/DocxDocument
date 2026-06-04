namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltrendlinetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("XlTrendlineType")]
public enum TrendlineType
{
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^6 + bx^5 + cx^4 + dx^3
  /// + ex^2 + fx + g.
  /// </summary>
  [WordInteropEnumValue("xlPolynomial")]
  Polynomial = 3,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^b.
  /// </summary>
  [WordInteropEnumValue("xlPower")]
  Power = 4,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y=ab^x .
  /// </summary>
  [WordInteropEnumValue("xlExponential")]
  Exponential = 5,
  /// <summary>
  /// Uses a sequence of averages computed from parts of the data series. The number of points equals the total
  /// number of points in the series less the number specified for the period.
  /// </summary>
  [WordInteropEnumValue("xlMovingAvg")]
  MovingAvg = 6,
  /// <summary>
  /// Uses the equation y = c ln x + b to calculate the least squares fit through points.
  /// </summary>
  [WordInteropEnumValue("xlLogarithmic")]
  Logarithmic = -4133,
  /// <summary>
  /// Uses the linear equation y = mx + b to calculate the least squares fit through points.
  /// </summary>
  [WordInteropEnumValue("xlLinear")]
  Linear = -4132
}
