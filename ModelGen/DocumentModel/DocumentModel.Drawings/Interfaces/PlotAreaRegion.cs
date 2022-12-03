namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public interface PlotAreaRegion // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface { get ; set; }
  
  public Collection<Series>? Serieses { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
