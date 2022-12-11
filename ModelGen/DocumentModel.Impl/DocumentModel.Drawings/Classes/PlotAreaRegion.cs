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
  
  public PlotAreaRegionImpl(): base() {}
  
  public PlotAreaRegionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PlotAreaRegion openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// PlotSurface.
  /// </summary>
  public PlotSurface? PlotSurface
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Series>? Serieses
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
