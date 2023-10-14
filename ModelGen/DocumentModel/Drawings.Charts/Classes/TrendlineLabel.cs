namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Trendline Label.
/// </summary>
public partial class TrendlineLabel
{
  
  /// <summary>
  ///   Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  
  /// <summary>
  ///   ChartText.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartText? ChartText { get; set; }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  public DocumentModel.Drawings.Charts.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
