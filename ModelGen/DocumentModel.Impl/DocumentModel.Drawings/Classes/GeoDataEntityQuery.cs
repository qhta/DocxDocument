namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataEntityQuery Class.
/// </summary>
public class GeoDataEntityQueryImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataEntityQuery>, GeoDataEntityQuery
{
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
  
}
