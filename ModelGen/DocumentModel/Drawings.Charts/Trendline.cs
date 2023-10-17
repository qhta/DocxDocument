namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Trendline Class.
/// </summary>
public partial class Trendline
{
  
  /// <summary>
  ///   Trendline Name.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineName? TrendlineName { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Trendline Type.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineKind? TrendlineType { get; set; }
  
  
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
  public DocumentModel.Drawings.Charts.Forward? Forward { get; set; }
  
  
  /// <summary>
  ///   Backward.
  /// </summary>
  public DocumentModel.Drawings.Charts.Backward? Backward { get; set; }
  
  
  /// <summary>
  ///   Intercept.
  /// </summary>
  public DocumentModel.Drawings.Charts.Intercept? Intercept { get; set; }
  
  
  /// <summary>
  ///   Display R Squared Value.
  /// </summary>
  public DocumentModel.Drawings.Charts.DisplayRSquaredValue? DisplayRSquaredValue { get; set; }
  
  
  /// <summary>
  ///   Display Equation.
  /// </summary>
  public DocumentModel.Drawings.Charts.DisplayEquation? DisplayEquation { get; set; }
  
  
  /// <summary>
  ///   Trendline Label.
  /// </summary>
  public DocumentModel.Drawings.Charts.TrendlineLabel? TrendlineLabel { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
