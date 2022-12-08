namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoChildEntitiesQueryResult Class.
/// </summary>
public class GeoChildEntitiesQueryResultImpl: ModelElementImpl, GeoChildEntitiesQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoChildEntitiesQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// GeoChildEntitiesQuery.
  /// </summary>
  public GeoChildEntitiesQuery? GeoChildEntitiesQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoChildEntities.
  /// </summary>
  public GeoChildEntities? GeoChildEntities
  {
    get;
    set;
  }
  
}
