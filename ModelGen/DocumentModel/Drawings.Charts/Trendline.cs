namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Trendline Class.
/// </summary>
public partial class Trendline
{
  
  /// <summary>
  ///   Trendline Name.
  /// </summary>
  public DMDC.TrendlineName? TrendlineName { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   Trendline Type.
  /// </summary>
  public DMDC.TrendlineKind? TrendlineType { get; set; }
  
  
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
  public DMDC.Forward? Forward { get; set; }
  
  
  /// <summary>
  ///   Backward.
  /// </summary>
  public DMDC.Backward? Backward { get; set; }
  
  
  /// <summary>
  ///   Intercept.
  /// </summary>
  public DMDC.Intercept? Intercept { get; set; }
  
  
  /// <summary>
  ///   Display R Squared Value.
  /// </summary>
  public DMDC.DisplayRSquaredValue? DisplayRSquaredValue { get; set; }
  
  
  /// <summary>
  ///   Display Equation.
  /// </summary>
  public DMDC.DisplayEquation? DisplayEquation { get; set; }
  
  
  /// <summary>
  ///   Trendline Label.
  /// </summary>
  public DMDC.TrendlineLabel? TrendlineLabel { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
