namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public class PlotAreaRegion
{
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface { get; set; }

  public Collection<Series>? Serieses { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}