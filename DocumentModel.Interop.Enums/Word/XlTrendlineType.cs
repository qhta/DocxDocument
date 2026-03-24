namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
/// </summary>
public enum XlTrendlineType
{
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  Polynomial = 3,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^b. xlExponential5 Uses
  /// an equation to calculate the least squares fit through points, for example, y=ab^x .
  /// </summary>
  Power = 4,
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  Exponential = 5,
  /// <summary>
  /// Uses a sequence of averages computed from parts of the data series. The number of points equals the total
  /// number of points in the series less the number specified for the period.
  /// </summary>
  MovingAvg = 6,
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  Logarithmic = -4133,
  /// <summary>
  /// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
  /// </summary>
  Linear = -4132
}
