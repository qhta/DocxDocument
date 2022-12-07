namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoLocation Class.
/// </summary>
public class GeoLocationImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoLocation>, GeoLocation
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
  
  /// <summary>
  /// Address.
  /// </summary>
  public Address? Address
  {
    get;
    set;
  }
  
}
