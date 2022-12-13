namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PlotSurface Class.
/// </summary>
public interface PlotSurface
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
