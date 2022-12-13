namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public interface Trendline
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  public String? TrendlineName { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineKind? TrendlineType { get ; set; }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  public Byte? PolynomialOrder { get ; set; }
  
  /// <summary>
  /// Period.
  /// </summary>
  public UInt32? Period { get ; set; }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public Double? Forward { get ; set; }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public Double? Backward { get ; set; }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public Double? Intercept { get ; set; }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public Boolean? DisplayRSquaredValue { get ; set; }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public Boolean? DisplayEquation { get ; set; }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
