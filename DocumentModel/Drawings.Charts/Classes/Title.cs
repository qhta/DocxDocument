namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Title.
/// </summary>
public partial class Title
{
  /// <summary>
  /// Chart Text.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartText? ChartText { get; set; }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.Layout? Layout { get; set; }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public Boolean? Overlay { get; set; }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties { get; set; }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
