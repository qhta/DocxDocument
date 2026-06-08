namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the IPlotArea Class.
/// </summary>
public class IPlotArea: ModelElement
{
  /// <summary>
  ///   PlotAreaRegion.
  /// </summary>
  public PlotAreaRegion? PlotAreaRegion { get; set; }

  public Collection<IAxis>? IAxis { get; set; }

  public ShapeProperties? ShapeProperties { get; set; }

  public ExtensionList? ExtensionList { get; set; }
}
