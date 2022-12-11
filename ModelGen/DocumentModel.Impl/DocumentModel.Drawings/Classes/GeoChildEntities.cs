namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntities Class.
/// </summary>
public class GeoChildEntitiesImpl: ModelElementImpl, GeoChildEntities
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoChildEntitiesImpl(): base() {}
  
  public GeoChildEntitiesImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntities openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public Collection<GeoHierarchyEntity>? GeoHierarchyEntities
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
