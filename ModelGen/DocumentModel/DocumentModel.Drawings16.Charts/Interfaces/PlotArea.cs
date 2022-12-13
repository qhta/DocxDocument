namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public interface PlotArea
{
  /// <summary>
  /// PlotAreaRegion.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PlotAreaRegion? PlotAreaRegion { get ; set; }
  
  public Collection<DocumentModel.Drawings16.Charts.Axis>? Axises { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ShapeProperties? ShapeProperties { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
