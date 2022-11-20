namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IChartShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDisplayRSquaredValue))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IDisplayEquation))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IForward))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IBackward))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IIntercept))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPolynomialOrder))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPeriod))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITrendlineLabel))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITrendlineType))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.ITrendlineName))]
public interface ITrendline // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public IIntercept? Intercept { get ; set; }
  
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
  public DocumentModel.Drawing.Charts.ITrendlineLabel? TrendlineLabel { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList { get ; set; }
  
}
