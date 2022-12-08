namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PlotAreaRegion Class.
/// </summary>
public class PlotAreaRegionImpl: ModelElementImpl, PlotAreaRegion
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface
  {
    get;
    set;
  }
  
  public Collection<Series>? Serieses
  {
    get;
    set;
  }
  
  public ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
