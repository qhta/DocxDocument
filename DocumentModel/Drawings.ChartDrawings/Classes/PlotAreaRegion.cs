namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public class PlotAreaRegion: ModelElement
{
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface { get; set; }

  public Collection<Series>? Series { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}