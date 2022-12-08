namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// entityType, this property is only available in Office 2016 and later.
  /// </summary>
  public EntityTypeEnum? EntityType
  {
    get => (EntityTypeEnum?)OpenXmlElement?.EntityType?.Value;
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
    get;
    set;
  }
  
}
