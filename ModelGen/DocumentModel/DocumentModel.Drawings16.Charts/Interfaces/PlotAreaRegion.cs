namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public interface PlotAreaRegion
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public DocumentModel.Drawings16.Charts.PlotSurface? PlotSurface { get ; set; }
  
  public Collection<DocumentModel.Drawings16.Charts.Series>? Serieses { get ; set; }
  
  public DocumentModel.Drawings16.Charts.ExtensionList? ExtensionList { get ; set; }
  
}
