namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ITrendline Class.
/// </summary>
public class ITrendline: ModelElement
{
  /// <summary>
  ///   ITrendline Name.
  /// </summary>
  public string? TrendlineName { get; set; }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get; set; }

  /// <summary>
  ///   ITrendline Type.
  /// </summary>
  public TrendlineKind? TrendlineType { get; set; }

  /// <summary>
  ///   Polynomial ITrendline Order.
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
  ///   ITrendline Label.
  /// </summary>
  public TrendlineLabel? TrendlineLabel { get; set; }

  /// <summary>
  ///   IChart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}
