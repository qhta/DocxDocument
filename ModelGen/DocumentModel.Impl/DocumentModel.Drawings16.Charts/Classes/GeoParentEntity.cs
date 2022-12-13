namespace DocumentModel.Drawings16.Charts;

/// <summary>
/// Defines the GeoParentEntity Class.
/// </summary>
public class GeoParentEntityImpl: ModelElementImpl, GeoParentEntity
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntity?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
