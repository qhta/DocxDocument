namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoHierarchyEntity Class.
/// </summary>
public partial class GeoHierarchyEntityImpl: ModelElementImpl, GeoHierarchyEntity
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GeoHierarchyEntityImpl(): base() {}
  
  public GeoHierarchyEntityImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoHierarchyEntity openXmlElement): base(openXmlElement)
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
