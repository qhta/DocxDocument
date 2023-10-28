namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Title.
/// </summary>
public partial class Title
{
  
  /// <summary>
  ///   Chart Text.
  /// </summary>
  public DMDC.ChartText? ChartText { get; set; }
  
  
  /// <summary>
  ///   Layout.
  /// </summary>
  public DMDC.Layout? Layout { get; set; }
  
  
  /// <summary>
  ///   Overlay.
  /// </summary>
  public DMDC.Overlay? Overlay { get; set; }
  
  
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
