namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoDataPointToEntityQuery Class.
/// </summary>
public class GeoDataPointToEntityQueryImpl: ModelElementImpl, GeoDataPointToEntityQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataPointToEntityQueryImpl(): base() {}
  
  public GeoDataPointToEntityQueryImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointToEntityQuery openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.EntityTypeEnum? EntityType
  {
    get => (DocumentModel.Drawings.ChartDrawings.EntityTypeEnum?)OpenXmlElement?.EntityType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityType = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.EntityTypeEnum?)value;
    }
  }
  
  /// <summary>
  /// entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId
  {
    get => (System.String?)OpenXmlElement?.EntityId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityId = (System.String?)value;
    }
  }
  
}
