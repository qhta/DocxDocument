namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoEntity Class.
/// </summary>
public class GeoEntityImpl: ModelElementImpl, GeoEntity
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoEntityImpl(): base() {}
  
  public GeoEntityImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoEntity openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName
  {
    get => (System.String?)OpenXmlElement?.EntityName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.EntityName = (System.String?)value;
    }
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
  
}
