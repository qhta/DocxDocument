namespace DocumentModel.Drawings;

/// <summary>
/// Trendline Label.
/// </summary>
public interface TrendlineLabel1
{
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout1? Layout { get ; set; }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public ChartText1? ChartText { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public NumberingFormat2? NumberingFormat { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties1? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList3? ExtensionList { get ; set; }
  
}
