namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public interface ITrendline // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Trendline Name.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TrendlineName { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawing.Charts.IChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public DocumentModel.Drawing.Charts.TrendlineKind? TrendlineType { get ; set; }
  
  /// <summary>
  /// Polynomial Trendline Order.
  /// </summary>
  public System.Byte? PolynomialOrder { get ; set; }
  
  /// <summary>
  /// Period.
  /// </summary>
  public System.UInt32? Period { get ; set; }
  
  /// <summary>
  /// Forward.
  /// </summary>
  public System.Double? Forward { get ; set; }
  
  /// <summary>
  /// Backward.
  /// </summary>
  public System.Double? Backward { get ; set; }
  
  /// <summary>
  /// Intercept.
  /// </summary>
  public System.Double? Intercept { get ; set; }
  
  /// <summary>
  /// Display R Squared Value.
  /// </summary>
  public System.Boolean? DisplayRSquaredValue { get ; set; }
  
  /// <summary>
  /// Display Equation.
  /// </summary>
  public System.Boolean? DisplayEquation { get ; set; }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public DocumentModel.Drawing.Charts.ITrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
