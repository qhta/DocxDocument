namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PlotArea Class.
/// </summary>
public interface PlotArea
{
  /// <summary>
  ///   PlotAreaRegion.
  /// </summary>
  public PlotAreaRegion? PlotAreaRegion { get; set; }
  public AxisList? Axis { get; set; }
  public ShapeProperties? ShapeProperties { get; set; }
  public ExtensionList? ExtensionList { get; set; }
}