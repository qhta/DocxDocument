namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how the trendline that smoothes out fluctuations in the data is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xltrendlinetype?view=office-pia` for Office interop details.
/// </remarks>
public enum XlTrendlineType
{
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^6 + bx^5 + cx^4 + dx^3
  /// + ex^2 + fx + g.
  /// </summary>
  Polynomial = 3,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^b.
  /// </summary>
  Power = 4,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y=ab^x .
  /// </summary>
  Exponential = 5,
  /// <summary>
  /// Uses a sequence of averages computed from parts of the data series. The number of points equals the total
  /// number of points in the series less the number specified for the period.
  /// </summary>
  MovingAvg = 6,
  /// <summary>
  /// Uses the equation y = c ln x + b to calculate the least squares fit through points.
  /// </summary>
  Logarithmic = -4133,
  /// <summary>
  /// Uses the linear equation y = mx + b to calculate the least squares fit through points.
  /// </summary>
  Linear = -4132
}
