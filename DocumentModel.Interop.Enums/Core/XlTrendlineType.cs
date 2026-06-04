
namespace DocumentModel.Interop.Core;

/// <summary>
/// You should access and use this enumeration from the Excel primary interop assembly (PIA). Specifies how the
/// trendline that smoothes out fluctuations in the data is calculated.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.xltrendlinetype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("XlTrendlineType")]
public enum TrendlineType
{
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y=ab^x .
  /// </summary>
  [OfficeInteropEnumValue("xlExponential")]
  Exponential = 5,
  /// <summary>
  /// Uses the linear equation y = mx + b to calculate the least squares fit through points.
  /// </summary>
  [OfficeInteropEnumValue("xlLinear")]
  Linear = -4132,
  /// <summary>
  /// Uses the equation y = c ln x + b to calculate the least squares fit through points.
  /// </summary>
  [OfficeInteropEnumValue("xlLogarithmic")]
  Logarithmic = -4133,
  /// <summary>
  /// Uses a sequence of averages computed from parts of the data
  /// </summary>
  [OfficeInteropEnumValue("xlMovingAvg")]
  MovingAvg = 6,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^6 + bx^5 + cx^4 + dx^3
  /// + ex^2 + fx + g.
  /// </summary>
  [OfficeInteropEnumValue("xlPolynomial")]
  Polynomial = 3,
  /// <summary>
  /// Uses an equation to calculate the least squares fit through points, for example, y = ax^b.
  /// </summary>
  [OfficeInteropEnumValue("xlPower")]
  Power = 4
}
