namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntitiesQuery Class.
/// </summary>
public class GeoParentEntitiesQueryImpl: ModelElementImpl, GeoParentEntitiesQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoParentEntitiesQueryImpl(): base() {}
  
  public GeoParentEntitiesQueryImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId
  {
    get => (String?)OpenXmlElement?.EntityId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityId = (System.String?)value;
    }
  }
  
}
