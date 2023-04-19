namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Trendline Class.
/// </summary>
public class Trendline: ModelElement
{
  /// <summary>
  ///   Trendline Name.
  /// </summary>
  public string? TrendlineName { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   Trendline Type.
  /// </summary>
  public TrendlineKind? TrendlineType { get; set; }

  /// <summary>
  ///   Polynomial Trendline Order.
  /// </summary>
  public Byte? PolynomialOrder { get; set; }

  /// <summary>
  ///   Period.
  /// </summary>
  public UInt32? Period { get; set; }

  /// <summary>
  ///   Forward.
  /// </summary>
  public Double? Forward { get; set; }

  /// <summary>
  ///   Backward.
  /// </summary>
  public Double? Backward { get; set; }

  /// <summary>
  ///   Intercept.
  /// </summary>
  public Double? Intercept { get; set; }

  /// <summary>
  ///   Display R Squared Value.
  /// </summary>
  public bool? DisplayRSquaredValue { get; set; }

  /// <summary>
  ///   Display Equation.
  /// </summary>
  public bool? DisplayEquation { get; set; }

  /// <summary>
  ///   Trendline Label.
  /// </summary>
  public TrendlineLabel? TrendlineLabel { get; set; }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}