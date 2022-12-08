namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GeoParentEntitiesQueryResult Class.
/// </summary>
public class GeoParentEntitiesQueryResultImpl: ModelElementImpl, GeoParentEntitiesQueryResult
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.GeoParentEntitiesQueryResult?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// GeoParentEntitiesQuery.
  /// </summary>
  public GeoParentEntitiesQuery? GeoParentEntitiesQuery
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoEntity.
  /// </summary>
  public GeoEntity? GeoEntity
  {
    get;
    set;
  }
  
  /// <summary>
  /// GeoParentEntity.
  /// </summary>
  public GeoParentEntity? GeoParentEntity
  {
    get;
    set;
  }
  
}
