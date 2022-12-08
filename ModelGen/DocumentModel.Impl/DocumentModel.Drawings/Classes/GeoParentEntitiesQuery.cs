namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntitiesQuery Class.
/// </summary>
public class GeoParentEntitiesQueryImpl: ModelElementImpl, GeoParentEntitiesQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQuery?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
