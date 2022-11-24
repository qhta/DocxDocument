namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public interface ITrendline // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  public ITrendlineName? TrendlineName { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public ITrendlineType? TrendlineType { get ; set; }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  public IPolynomialOrder? PolynomialOrder { get ; set; }
  
  /// <summary>
  /// Period.
  /// </summary>
  public IPeriod? Period { get ; set; }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public IForward? Forward { get ; set; }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public IBackward? Backward { get ; set; }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public Intercept? Intercept { get ; set; }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public IDisplayRSquaredValue? DisplayRSquaredValue { get ; set; }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public IDisplayEquation? DisplayEquation { get ; set; }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public ITrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
