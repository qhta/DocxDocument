namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public interface PlotAreaRegion
{
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface { get ; set; }
  
  public ExtensionList2? ExtensionList { get ; set; }
  
}
