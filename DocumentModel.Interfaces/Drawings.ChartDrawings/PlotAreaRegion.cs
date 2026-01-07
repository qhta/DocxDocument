namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public interface PlotAreaRegion
{
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface { get; set; }
  public Series Series { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}