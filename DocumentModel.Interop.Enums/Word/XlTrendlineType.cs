namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
/// </summary>
public enum XlTrendlineType
{
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  xlPolynomial = unchecked((int)3),
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^b. xlExponential5 Uses
  /// an equation to calculate the least squares fit through points, for example, y=ab^x .
  /// </summary>
  xlPower = unchecked((int)4),
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  xlExponential = unchecked((int)5),
  /// <summary>
  /// Uses a sequence of averages computed from parts of the data series. The number of points equals the total
  /// number of points in the series less the number specified for the period.
  /// </summary>
  xlMovingAvg = unchecked((int)6),
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  xlLogarithmic = unchecked((int)-4133),
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  xlLinear = unchecked((int)-4132)
}
