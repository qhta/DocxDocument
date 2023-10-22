namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the PlotArea Class.
/// </summary>
public partial class PlotArea
{
  
  /// <summary>
  ///   PlotAreaRegion.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.PlotAreaRegion? PlotAreaRegion { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.ChartDrawings.ExtensionList? ExtensionList { get; set; }
  
}
