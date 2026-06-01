namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PlotAreaRegion Class.
/// </summary>
public class PlotAreaRegion: ModelElement
{
  /// <summary>
  ///   PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface { get; set; }

  public Collection<ISeries>? ISeries { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
