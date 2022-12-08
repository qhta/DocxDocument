namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntitiesQuery Class.
/// </summary>
public class GeoChildEntitiesQueryImpl: ModelElementImpl, GeoChildEntitiesQuery
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQuery?)_OpenXmlElement;
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
  
  /// <summary>
  /// GeoChildTypes.
  /// </summary>
  public GeoChildTypes? GeoChildTypes
  {
    get;
    set;
  }
  
}
