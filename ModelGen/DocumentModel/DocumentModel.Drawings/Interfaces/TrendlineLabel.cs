namespace DocumentModel.Drawings;

/// <summary>
/// Trendline Label.
/// </summary>
public interface TrendlineLabel // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout? Layout { get ; set; }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public ChartText? ChartText { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties { get ; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties? TextProperties { get ; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
