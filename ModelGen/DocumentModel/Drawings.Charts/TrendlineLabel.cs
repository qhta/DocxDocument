namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Trendline Label.
/// </summary>
public partial class TrendlineLabel
{
  
  /// <summary>
  ///   Layout.
  /// </summary>
  public DMDC.Layout? Layout { get; set; }
  
  
  /// <summary>
  ///   ChartText.
  /// </summary>
  public DMDC.ChartText? ChartText { get; set; }
  
  
  /// <summary>
  ///   Number Format.
  /// </summary>
  public DMDC.NumberingFormat? NumberingFormat { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   TextProperties.
  /// </summary>
  public DMDC.TextProperties? TextProperties { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
