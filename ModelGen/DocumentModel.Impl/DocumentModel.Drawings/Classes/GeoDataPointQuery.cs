namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoDataPointQuery Class.
/// </summary>
public class GeoDataPointQueryImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoDataPointQuery>, GeoDataPointQuery
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
