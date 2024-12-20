namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public partial class GeoParentEntityImpl: ModelElementImpl, GeoParentEntity
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public GeoParentEntityImpl(): base() {}
  
  public GeoParentEntityImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
