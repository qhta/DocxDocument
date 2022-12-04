namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Trendline Class.
/// </summary>
public class Trendline
{
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Trendline Type.
  /// </summary>
  public TrendlineKind? TrendlineType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Trendline Label.
  /// </summary>
  public TrendlineLabel2? TrendlineLabel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
