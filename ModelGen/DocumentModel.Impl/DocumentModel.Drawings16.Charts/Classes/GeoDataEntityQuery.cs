namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoDataEntityQuery Class.
/// </summary>
public class GeoDataEntityQueryImpl: ModelElementImpl, GeoDataEntityQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoDataEntityQueryImpl(): base() {}
  
  public GeoDataEntityQueryImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Drawings16.Charts.EntityTypeEnum? EntityType
  {
    get => (DocumentModel.Drawings16.Charts.EntityTypeEnum?)OpenXmlElement?.EntityType?.Value;
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
