namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PlotSurface Class.
/// </summary>
public record PlotSurface
{
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList { get; set; }
}