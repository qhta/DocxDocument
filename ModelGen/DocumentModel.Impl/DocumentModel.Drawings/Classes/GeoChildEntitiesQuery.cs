namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public class GeoChildEntitiesQueryImpl: ModelElementImpl, GeoChildEntitiesQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  public GeoChildTypes? GeoChildTypes
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
