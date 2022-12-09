namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoPolygons Class.
/// </summary>
public class GeoPolygonsImpl: ModelElementImpl, GeoPolygons
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoPolygons?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Collection<GeoPolygon>? Items
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
